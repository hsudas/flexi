using Flexi.WebUI.Models;
using Npgsql;
using Flexi.Model.DM;
using Flexi.Business.Business;
using Flexi.Business.Business.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Flexi.Model.Entity.Dashboard;

namespace Flexi.WebUI.Controllers
{
    public class OperationController : ApiController
    {
        [HttpPost]
        public DataManagementModel GetData([FromBody]List<DMParameter> param,string dmId)
        {
            int definitionId = 0;
            if (!int.TryParse(dmId,out definitionId))
            {
                throw new Exception("Definition Id must be a valid integer number!");
            }
            DataManagementModel dataModel = new DataManagementModel();
            QueryManager qm = new QueryManager();
            List<DMDefinition> defList = qm.GetQueryResultDirect<DMDefinition>("SELECT * FROM dmdefinition WHERE id=@dmid", qm.GetSingleParameter<int>("dmid", definitionId));
            List<IDataParameter> tableParameters = GenereateDBParameterFromBody(param);
            List<DMColumnRelation> columnRelationList = qm.GetQueryResultDirect<DMColumnRelation>("SELECT * FROM dmcolumnrelation WHERE dmid=@dmid", qm.GetSingleParameter<int>("dmid", definitionId));
            dataModel.QueryName = defList[0].QueryName;
            dataModel.Definition = defList[0].Description;
            DataTable tblData = qm.GetQueryResultDataTable(defList[0].QueryName,tableParameters);//todo: parse parameters..
            List<DataManagementColumns> columnList = new List<DataManagementColumns>();
            foreach (var crel in columnRelationList)
            {
                string schema = "";
                string table = crel.TableName;
                StringBuilder sbQuery = new StringBuilder();
                List<AppEnum> enumlist = ApplicationBusiness.GetEnum(crel.TableName);
                sbQuery.Append("select column_name, data_type, is_nullable, column_default from information_schema.columns where table_name = @table_name ");
                sbQuery.Append("and(column_default not like '%nextval%' and column_default not like '%now%' or column_default is null) ");
                sbQuery.Append("and column_name not in (select columnname from dmrestriction where tablename = @table_name)");
                string query = sbQuery.ToString();
                if (crel.TableName.Contains('.'))
                {
                    string[] slicedTableNameArray = crel.TableName.Split('.');
                    schema = slicedTableNameArray[0];
                    table = slicedTableNameArray[1];
                    //query = "select column_name,data_type,is_nullable,column_default from information_schema.columns where table_name = @table_name and(column_default not like '%nextval%' and column_default not like '%now%' or column_default is null) and table_schema='"+ schema + "';";
                    query = query + "and table_schema = '" + schema + "'; ";
                }
                List<TableStructure> columnNames =  qm.GetQueryResultDirect<TableStructure>(query, qm.GetSingleParameter<string>("table_name",table));
                crel.TableColumns = GenerateTableStructureWithEnum(columnNames,enumlist);
            }
            foreach (DataColumn column in tblData.Columns)
            {
                columnList.Add(new DataManagementColumns
                {
                    title = column.ColumnName,
                    DataType = column.DataType.ToString()

                });
            }
            dataModel.Columns = columnList.ToArray<DataManagementColumns>();
            dataModel.Data = GenerateStringArrayListForWebGrid(tblData);
            dataModel.ColumnRelations = columnRelationList;
            return dataModel;
        }

        public DataManagementModel GetTableModel(string tableName,string queryKeyColumn,string tableKeyColumn)
        {
           
     
            DataManagementModel dataModel = new DataManagementModel();
            QueryManager qm = new QueryManager();


            List<DMColumnRelation> columnRelationList = new List<DMColumnRelation>();
            columnRelationList.Add(new DMColumnRelation { TableName = tableName, QueryColumnName = queryKeyColumn, TableColumnName = tableKeyColumn });
            List<DataManagementColumns> columnList = new List<DataManagementColumns>();
            foreach (var crel in columnRelationList)
            {
                string schema = "";
                string table = crel.TableName;
                StringBuilder sbQuery = new StringBuilder();
                List<AppEnum> enumlist = ApplicationBusiness.GetEnum(crel.TableName);
                sbQuery.Append("select column_name, data_type, is_nullable, column_default from information_schema.columns where table_name = @table_name ");
                sbQuery.Append("and(column_default not like '%nextval%' and column_default not like '%now%' or column_default is null) ");
                sbQuery.Append("and column_name not in (select columnname from dmrestriction where tablename = @table_name)");
                string query = sbQuery.ToString();
                if (crel.TableName.Contains('.'))
                {
                    string[] slicedTableNameArray = crel.TableName.Split('.');
                    schema = slicedTableNameArray[0];
                    table = slicedTableNameArray[1];
                    //query = "select column_name,data_type,is_nullable,column_default from information_schema.columns where table_name = @table_name and(column_default not like '%nextval%' and column_default not like '%now%' or column_default is null) and table_schema='"+ schema + "';";
                    query = query + "and table_schema = '" + schema + "'; ";
                }
                List<TableStructure> columnNames = qm.GetQueryResultDirect<TableStructure>(query, qm.GetSingleParameter<string>("table_name", table));
                crel.TableColumns = GenerateTableStructureWithEnum(columnNames, enumlist);
            }
            //foreach (DataColumn column in tblData.Columns)
            //{
            //    columnList.Add(new DataManagementColumns
            //    {
            //        title = column.ColumnName,
            //        DataType = column.DataType.ToString()

            //    });
            //}
          //  dataModel.Columns = columnList.ToArray<DataManagementColumns>();
           // dataModel.Data = GenerateStringArrayListForWebGrid(tblData);
            dataModel.ColumnRelations = columnRelationList;
            return dataModel;
        }

        [HttpPost]
        public DataResponse ExecuteData([FromBody]List<DataRequest> dataRequestList)
        {
          
            DataResponse dataResponse = new DataResponse();
            dataResponse.ResponseMessage = dataRequestList.Count.ToString();
            string query = "";
            int affectedRows = 0;
            bool isDeleteOperation = false;
            foreach (var dataRequest in dataRequestList)
            {
                string comma = ",";
                StringBuilder sb = new StringBuilder();
                if (string.IsNullOrEmpty(dataRequest.KeyColumnValue))
                {
                    dataResponse.ResponseMessage = "Record has not been found. You can't update!";
                    dataResponse.ResponseCode = "1";
                    return dataResponse;
                }
                if (dataRequest.OperationType == "update")
                {
                    sb.Append("UPDATE ");
                    sb.Append(dataRequest.TableName + " SET ");
                    int index = 0;
                    foreach (var item in dataRequest.Columns)
                    {
                        if (index==dataRequest.Columns.Count-1)
                        {
                            comma = "";
                        }
                        if (string.IsNullOrEmpty(item.ColumnValue))
                        {
                            sb.Append(item.ColumnName + "=NULL" + comma);

                        }
                        else
                        {
                            sb.Append(item.ColumnName + "='" + item.ColumnValue.Replace("'","''") + "'" + comma);

                        }
                        index++;
                    }
                    sb.Append(" WHERE " + dataRequest.KeyColumnName + " = '" + dataRequest.KeyColumnValue.Replace("'", "''") + "';");
                    query = sb.ToString();      
                }
                else if (dataRequest.OperationType == "insert")
                {
                    sb.Append("INSERT INTO ");
                    sb.Append(dataRequest.TableName+"(");
                    StringBuilder sbValues = new StringBuilder();
                    sbValues.Append(" VALUES(");
                    int index = 0;
                    foreach (var item in dataRequest.Columns)
                    {
                        if (index == dataRequest.Columns.Count - 1)
                        {
                            comma = "";
                        }
                        sb.Append(item.ColumnName + comma);
                        if (string.IsNullOrEmpty(item.ColumnValue))
                        {
                            sbValues.Append("NULL" + comma);

                        }
                        else
                        {
                            sbValues.Append("'" + item.ColumnValue.Replace("'", "''") + "'" + comma);

                        }
                       
                        index++;
                    }
                    sb.Append(") ");
                    sbValues.Append(") ");
                   
                    query = sb.ToString() + sbValues.ToString();
                }
                else if (dataRequest.OperationType == "delete")
                {
                    isDeleteOperation = true;
                    if(dataRequest.Columns.Where(x => x.ColumnName == "status" && x.DataType == "boolean").Count() > 0)
                    {
                        query  = "UPDATE " +dataRequest.TableName+" SET status='false' WHERE " + dataRequest.KeyColumnName + "='" + dataRequest.KeyColumnValue.Replace("'", "''") + "'"; 
                    }
                    else if (dataRequest.Columns.Where(x => x.ColumnName == "status").Count() > 0)
                    {
                        query = "UPDATE " + dataRequest.TableName + " SET status=0 WHERE " + dataRequest.KeyColumnName + "='" + dataRequest.KeyColumnValue.Replace("'", "''") + "'";

                    }
                    else
                    {
                        query = "DELETE FROM " + dataRequest.TableName + " WHERE " + dataRequest.KeyColumnName + "='" + dataRequest.KeyColumnValue.Replace("'", "''") + "'";
                    }
                }
                else
                {
                    dataResponse.ResponseMessage = "ERROR: operation type is not defined properly. operationType:";
                    dataResponse.ResponseCode = "1";

                }
               
                QueryManager qm = new QueryManager();
                try
                {
                    affectedRows = qm.ExecuteQueryText2(query);
                    if (affectedRows == 0)
                    {
                        dataResponse.ResponseCode = "9";
                        dataResponse.ResponseMessage = "0 Rows affected. Process terminated unsuccessfully.";
                        return dataResponse;
                    }
                }
                catch (Exception ex)
                {
                    dataResponse.ResponseCode = "-1";
                    dataResponse.ResponseMessage = ex.Message + ex.StackTrace;
                    return dataResponse;
                }
                
            }

            dataResponse.ResponseCode = "0";
            if(isDeleteOperation)
                dataResponse.ResponseMessage = "Your informations successfully deleted.";
            else
                dataResponse.ResponseMessage = "Your informations successfully saved.";

            return dataResponse;
        }

        public DataRow GetSelectedRow(string tableName,string columnName, string columnValue)
        {
            string query = "SELECT * FROM " + tableName + " WHERE " + columnName + " = '" + columnValue.Replace("'","''") + "';";
            QueryManager qm = new QueryManager();
          //  List<IDataParameter> parameterList = new List<IDataParameter>();
          //  parameterList.Add(new Flexi.Business.Model.DB.CustomParameter { ParameterName = columnName, Value = columnValue });
            DataTable tbl = qm.GetQueryResultDataTableDirect(query, null);
            if (tbl.Rows.Count == 0)
            {
                throw new Exception("Queried rows could not found");
            }
            return tbl.Rows[0];
        }

        public DataResponse CreateDMDefinition([FromBody]List<DMColumnRelation> columnRelations, string description, string queryName)
        {
            DataResponse dr = new DataResponse();
            try
            {
                DMDefinition dmDef = new DMDefinition();
                dmDef.Description = description;
                dmDef.QueryName = queryName;
                dmDef.Status = 1;
                QueryManager qm = new QueryManager();
                string queryText = qm.GetQueryText(queryName);
                if (string.IsNullOrEmpty(queryText))
                {
                    dr.ResponseMessage = "Query definition could not be found in appQuery table. Please define it first!";
                    dr.ResponseCode = "1";
                    return dr;
                }
                int dmId = qm.InsertObject<DMDefinition>(dmDef);
                foreach (var item in columnRelations)
                {
                    item.DMId = dmId;
                    qm.InsertObject<DMColumnRelation>(item);

                }
                dr.ResponseCode = "0";
                dr.ResponseMessage = "Your definitions successfully created!";
            }
            catch (Exception ex)
            {
                
                dr.ResponseMessage = "ERROR: " + ex.Message + ex.StackTrace;
                dr.ResponseCode = "1";
            }
            return dr;
           
        }
       

        private List<IDataParameter> GenereateDBParameterFromBody(List<DMParameter> param)
        {
            List<IDataParameter> dbp = null;
            if (param != null)
            {
                if (param.Count > 0)
                {
                    dbp = new List<IDataParameter>();
                    foreach (var item in param)
                    {
                        if (item.DataType == "date")
                        {
                            if (item.Value == "")
                            {
                                item.Value = DateTime.Now.ToString();
                            }
                            dbp.Add(new NpgsqlParameter(item.ParameterKey, DateTime.Parse(item.Value)));
                        }
                        else
                        {
                            dbp.Add(new NpgsqlParameter(item.ParameterKey, item.Value));

                        }
                    }
                }
            }
            return dbp;
        }
        private List<string[]> GenerateStringArrayListForWebGrid(DataTable dt)
        {
            List<string[]> dataStrList = new List<string[]>();
            foreach (DataRow item in dt.Rows)
            {
                string[] str = new string[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    str[i] = item[i].ToString();
                }
                dataStrList.Add(str);
            }
            return dataStrList;
        }
        private List<TableStructure> GenerateTableStructureWithEnum(List<TableStructure> tableStructureList, List<AppEnum> appEnumList)
        {
            if (appEnumList.Count > 0)
            {
                foreach (var item in tableStructureList)
                {
                    List<AppEnum> tempList = appEnumList.Where(q => q.EnumType == item.column_name).ToList<AppEnum>();
                    if (tempList.Count > 0)
                    {
                        item.enum_values = tempList;
                    }
                }
            }
           

            return tableStructureList;
        }
    }

    public class DataRequest
    {
        public string TableName { get; set; }
        public string KeyColumnName { get; set; }
        public string KeyColumnValue { get; set; }
        public string OperationType { get; set; }
        public List<Column> Columns { get; set; }
        public class Column
        {
            public string ColumnName { get; set; }
            public string ColumnValue { get; set; }
            public string DataType { get; set; }
        }
    }
    public class DataResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }
   
}
