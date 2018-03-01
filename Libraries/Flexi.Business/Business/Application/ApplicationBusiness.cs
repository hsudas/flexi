using Flexi.Shared.Helper;
using Flexi.Model.Entity.Dashboard;
using Flexi.Model.Poco;
using Flexi.Business.Business.DB;
using Flexi.Model.Application;
using Flexi.Model.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;

namespace Flexi.Business.Business
{
    public class ApplicationBusiness : BusinessBase
    {
        string url;
        string accesskey;
        string conStr = "";
        QueryManager qm;

        /// <summary>
        /// If you call this class without accesskey parameter, it will be conntect to db directly.
        /// </summary>
        public ApplicationBusiness() : base()
        {

            conStr = ConfigHelper.Instance.GetDBContext();
            qm = new QueryManager(conStr);
        }
        /// <summary>
        /// If you call this class with accesskey parameter, it will be connect to db via web api.
        /// </summary>
        /// <param name="accesskey"></param>
        public ApplicationBusiness(string accesskey) : base()
        {
            this.accesskey = accesskey;
            url = ConfigHelper.Instance.GetApiUrl();
        }
        public ApplicationBusiness(string accesskey, int institutionId) : base()
        {
            this.accesskey = accesskey;
            url = ConfigHelper.Instance.GetApiUrl();

            base.InstitutionId = institutionId;
        }
        public List<Application> GetApplications()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/app/GetApplications");
            request.Headers.Add("Authorization", this.accesskey);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            ServiceResponse<Application> sr = JsonHelper.Instance.DeserializeFromStream<ServiceResponse<Application>>(responseStream);
            if (sr.ResponseCode == 1)
            {
                return sr.ResponseList;
            }
            else
            {
                throw new Exception(sr.ResponseMessage);
            }
        }
        /// <summary>
        /// Get values in appparameter table  on db
        /// </summary>
        /// <param name="parameterName">parameter key value</param>
        /// <returns>parameter value</returns>
        public string GetParameterValue(string parameterName)
        {
            if (base.InstitutionId == 0)
            {
                base.InstitutionId = 1;
            }
            if (conStr != "")
            {
                List<IDataParameter> paramlist = new List<IDataParameter>();
                paramlist.Add(new CustomParameter { ParameterName = "parametername", Value = parameterName });
                paramlist.Add(new CustomParameter { ParameterName = "institutionid", Value = base.InstitutionId });

                List<AppParameter> res = qm.GetQueryResult<AppParameter>("GetParameter", paramlist);
                if (res.Count > 0)
                {
                    return res[0].ParameterValue;
                }
                throw new Exception("Parameter has not been found on db!");
            }
            else
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/app/GetParameter?parameterName=" + parameterName + "&institutionId=" + base.InstitutionId);
                request.Headers.Add("Authorization", this.accesskey);
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                ServiceResponse<AppParameter> sr = JsonHelper.Instance.DeserializeFromStream<ServiceResponse<AppParameter>>(responseStream);
                if (sr.ResponseCode == 1)
                {
                    if (sr.ResponseObject != null)
                    {
                        return sr.ResponseObject.ParameterValue;
                    }
                }
                else
                {
                    //                    Error Message :Exception while reading from stream
                    //Inner Exception :System.IO.IOException: Unable to read data from the transport connection: A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond. --->System.Net.Sockets.SocketException: A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond
                    //  at System.Net.Sockets.Socket.Receive(Byte[] buffer, Int32 offset, Int32 size, SocketFlags socketFlags)
                    //   at System.Net.Sockets.NetworkStream.Read(Byte[] buffer, Int32 offset, Int32 size)
                    //   -- - End of inner exception stack trace-- -
                    //    at System.Net.Sockets.NetworkStream.Read(Byte[] buffer, Int32 offset, Int32 size)
                    //   at Npgsql.ReadBuffer.Ensure(Int32 count, Boolean dontBreakOnTimeouts)
                    //Stack Trace :   at Npgsql.ReadBuffer.Ensure(Int32 count, Boolean dontBreakOnTimeouts)
                    //   at Npgsql.NpgsqlConnector.DoReadMessage(DataRowLoadingMode dataRowLoadingMode, Boolean isPrependedMessage)
                    //   at Npgsql.NpgsqlConnector.ReadMessageWithPrepended(DataRowLoadingMode dataRowLoadingMode)
                    //   at Npgsql.NpgsqlConnector.ReadExpecting[T]()
                    //   at Npgsql.NpgsqlDataReader.NextResultInternal()
                    //   at Npgsql.NpgsqlDataReader.NextResult()
                    //   at Npgsql.NpgsqlCommand.Execute(CommandBehavior behavior)
                    //   at Npgsql.NpgsqlCommand.ExecuteDbDataReaderInternal(CommandBehavior behavior)
                    //   at Npgsql.NpgsqlCommand.ExecuteDbDataReader(CommandBehavior behavior)
                    //   at System.Data.Common.DbCommand.System.Data.IDbCommand.ExecuteReader(CommandBehavior behavior)
                    //   at Dapper.SqlMapper.< QueryImpl > d__11`1.MoveNext()
                    //   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
                    //   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
                    //   at Dapper.SqlMapper.Query[T](IDbConnection cnn, String sql, Object param, IDbTransaction transaction, Boolean buffered, Nullable`1 commandTimeout, Nullable`1 commandType)
                    //   at Royal.Operation.Business.DB.QueryManager.GetQueryText(String queryName) in C:\GIT\feedframework\Royal.Operation\Business\DB\QueryManager.cs:line 57
                    //   at Royal.Operation.Business.DB.QueryManager.GetQueryResult[T](String queryName, List`1 cparams) in C:\GIT\feedframework\Royal.Operation\Business\DB\QueryManager.cs:line 123
                    //   at Royal.WebApi.Controllers.AppController.GetParameter(String parameterName) in C:\GIT\feedframework\Royal.WebApi\Controllers\AppController.cs:line 162

                    throw new Exception(sr.ResponseMessage);
                }
                throw new Exception("Parameter has not been found on db!");
            }

        }
        public static List<AppEnum> GetEnum(string group, string enumType)
        {
            QueryManager qm = new QueryManager();
            List<IDataParameter> parameterList = new List<IDataParameter>();
            parameterList.Add(new CustomParameter { ParameterName = "enumgroup", Value = group });
            parameterList.Add(new CustomParameter { ParameterName = "enumtype", Value = enumType });
            return qm.GetQueryResultDirect<AppEnum>("SELECT * FROM appenum WHERE enumgroup=@enumgroup AND enumtype=@enumtype", parameterList);
        }
        public static List<AppEnum> GetEnum(string group)
        {
            QueryManager qm = new QueryManager();
            List<IDataParameter> parameterList = new List<IDataParameter>();
            parameterList.Add(new CustomParameter { ParameterName = "enumgroup", Value = group });
            return qm.GetQueryResultDirect<AppEnum>("SELECT * FROM appenum WHERE enumgroup=@enumgroup", parameterList);
        }
    }
}
