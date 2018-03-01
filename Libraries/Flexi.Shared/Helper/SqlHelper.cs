using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using static Dapper.SqlMapper;

namespace Flexi.Shared.Helper
{
    public class SqlHelper
    {
        private static readonly Lazy<SqlHelper> lazy = new Lazy<SqlHelper>(() => new SqlHelper());
        public static SqlHelper Instance { get { return lazy.Value; } }

        private SqlHelper()
        {
        }

        protected IDbConnection Connection
        {
            get
            {
                IDbConnection connection = new NpgsqlConnection(ConfigHelper.Instance.GetDBContext());
                SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
                return connection;
            }
        }

        public List<T> ExecuteQuery<T>(string sql, object parameters = null)
        {
            List<T> list = null;
            using (System.Data.IDbConnection cn = Connection)
            {
                cn.Open();
                GridReader result = cn.QueryMultiple(sql, parameters);
                list = (List<T>)result.Read<T>();
            }
            return list;
        }

        public List<T> ExecuteQuery<T>(string connectionString, string sql)
        {
            List<T> list = null;
            using (System.Data.IDbConnection cn = Connection)
            {
                cn.ConnectionString = connectionString;
                cn.Open();
                GridReader result = cn.QueryMultiple(sql);
                list = (List<T>)result.Read<T>();
            }
            return list;
        }

        public int ExecuteSQL(string sql, object parameters = null)
        {
            int result = 0;
            if (!string.IsNullOrEmpty(sql))
            {
                using (IDbConnection cn = Connection)
                {
                    cn.Open();
                    //IDataReader reader = cn.ExecuteReader(sql);
                    result = cn.Execute(sql, parameters);
                }
            }
            return result;
        }

        public List<T> ExecuteQueryFromAppQuery<T>(string queryName)
        {
            List<T> list = null;
            using (System.Data.IDbConnection cn = Connection)
            {
                cn.Open();
                string sql = cn.ExecuteScalar<string>("select querytext from public.appquery where queryname=@queryname", new { queryname = queryName });
                GridReader result = cn.QueryMultiple(sql);
                list = (List<T>)result.Read<T>();
            }
            return list;
        }

        public Boolean IsSafeText(string text)
        {
            bool isSafe = true;
            string[] sqlCheckList = { "--",
                                       ";--",
                                       ";",
                                       "/*",
                                       "*/",
                                        "@@",
                                        "@",
                                        " char ",
                                       " nchar ",
                                       " varchar ",
                                       " nvarchar ",
                                       " alter ",
                                       "begin ",
                                       " cast ",
                                       " create ",
                                       " cursor ",
                                       " declare ",
                                       " delete ",
                                       " drop ",
                                       " end ",
                                       " exec ",
                                       "execute ",
                                       "fetch ",
                                         "insert ",
                                       "kill ",
                                          "select ",
                                        "sys",
                                         "sysobjects",
                                         "syscolumns",
                                        "table ",
                                        "update ",
                                        " or "
                                       };
            if (!string.IsNullOrEmpty(text))
            {
                string CheckString = text.Replace("'", "''");
                for (int i = 0; i <= sqlCheckList.Length - 1; i++)
                {
                    if ((CheckString.IndexOf(sqlCheckList[i], StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        isSafe = false;
                    }
                }
            }
            return isSafe;
        }
    }
}
