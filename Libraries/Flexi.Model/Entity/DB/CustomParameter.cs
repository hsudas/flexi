using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Flexi.Model.DB
{
    public class CustomParameter : IDataParameter
    {
        public CustomParameter()
        { }
        public CustomParameter(string ParameterName, object Value)
        {
            this.ParameterName = ParameterName;
            this.Value = Value;
        }
        private DbType dbType;
        public DbType DbType
        {
            get
            {
                return dbType;
            }
            set
            {
                dbType = value;
            }
        }

        private ParameterDirection pdir;
        public ParameterDirection Direction
        {
            get
            {
                return pdir;
            }
            set
            {
                pdir = value;
            }
        }

        private string parameterName;

        public string ParameterName
        {
            get
            {
                return parameterName;
            }
            set
            {
                parameterName = value; ;
            }
        }

        private object xvalue;

        public object Value
        {
            get
            {
                return xvalue;
            }
            set
            {
                xvalue = value;
            }
        }

        public static DynamicParameters GetDynamicParameters(List<CustomParameter> paramList)
        {
            DynamicParameters dpArgs = new DynamicParameters();
            foreach (var item in paramList)
            {
                dpArgs.Add(item.ParameterName, item.Value);
            }
            return dpArgs;
        }





        bool isnullable;

        public bool IsNullable
        {
            get { return isnullable; }
        }

        string sourceColumn;
        public string SourceColumn
        {
            get
            {
                return sourceColumn;
            }
            set
            {
                sourceColumn = value;
            }
        }
        DataRowVersion sourceVersion;
        public DataRowVersion SourceVersion
        {
            get
            {
                return sourceVersion;
            }
            set
            {
                sourceVersion = value;
            }
        }


    }
}
