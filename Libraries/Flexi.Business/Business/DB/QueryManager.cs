using Flexi.Shared.Helper;
using Flexi.Model.Poco;
using Flexi.Business.Business.DB.Ext;
using Flexi.Model.Application;
using Flexi.Model.DB;
using Dapper;
using Dapper.Contrib.Extensions;
using Npgsql;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Flexi.Business.Business.DB
{
    [Obsolete("Please use SqlHelper class instead of QueryManager")]
    public class QueryManager
    {
        public const String ISSET_BEGIN = "<ISSET ";
        public const String ISSET_END = ">";
        public const String ISSET_CLOSE = "</>";
        private bool? nolog = false;
        string ApiUrl;
        NpgsqlConnection con;
        NpgsqlTransaction transaction = null;
        string conStr = "";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="conStr">DB Connection String</param>
        public QueryManager(string conStr)
        {
            this.conStr = conStr;
        }
        public QueryManager()
        {
            this.conStr = ConfigHelper.Instance.GetDBContext();
            //this.conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        public QueryManager(string conStr, bool? nolog)
        {
            this.conStr = conStr;
            this.nolog = nolog;
        }
        bool workFromWeb = false;
        string accesskey = "";
        string url = "";
        public QueryManager(string accesskey, bool workfromweb)
        {
            this.accesskey = accesskey;
            this.workFromWeb = workfromweb;
            url = ConfigHelper.Instance.GetApiUrl();
            // url = ConfigurationManager.AppSettings["apiurl"];
        }
        public QueryManager(string conStr, string url)
        {
            this.conStr = conStr;
            ApiUrl = url;
        }
        public string GetQueryText(string queryName)
        {
            string result = "";
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                string query = "Select QueryText From AppQuery Where Status = 1 AND QueryName = @QueryName";
                result = con.Query<string>(query, new { QueryName = queryName }).FirstOrDefault<string>();
            }
            return result;
        }
        public string GetQueryText(int queryId)
        {
            string result = "";
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                string query = "Select QueryText From AppQuery Where Status = 1 AND QueryId = @QueryId";
                result = con.Query<string>(query, new { QueryId = queryId }).First<string>();
            }
            return result;
        }
        public QueryManager(string conStr, bool? nolog, string url)
        {
            this.conStr = conStr;
            this.nolog = nolog;
            ApiUrl = url;
        }
        public List<T> GetQueryResultDirect<T>(string queryText, List<IDataParameter> cparams = null)
        {

            List<T> result = new List<T>();
            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            queryText = RemoveUnsetParameters(queryText, cparams);
            try
            {
                using (con = new NpgsqlConnection(conStr))
                {
                    con.Open();
                    DynamicParameters parameters = null;
                    if (cparams != null)
                    {
                        if (cparams.Count > 0)
                        {
                            parameters = new DynamicParameters();
                            foreach (var item in cparams)
                            {
                                parameters.Add(item.ParameterName, item.Value);
                            }
                        }
                    }

                    result = con.Query<T>(queryText, parameters).ToList<T>();
                    tm2 = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                tm2 = DateTime.Now;
                span = tm2 - tm;
                ql.ExecutionTime = tm;
                ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                ql.QueryName = "Custom";
                ql.QueryText = queryText;
                CreateQueryLog(ql);
                throw ex;
            }


            return result;
        }
        public List<T> GetQueryResultDirect<T>(NpgsqlConnection con, string queryText, List<IDataParameter> cparams = null)
        {

            List<T> result = new List<T>();
            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            queryText = RemoveUnsetParameters(queryText, cparams);
            DynamicParameters parameters = null;
            if (cparams != null)
            {
                if (cparams.Count > 0)
                {
                    parameters = new DynamicParameters();
                    foreach (var item in cparams)
                    {
                        parameters.Add(item.ParameterName, item.Value);
                    }
                }
            }
            result = con.Query<T>(queryText, parameters).ToList<T>();
            tm2 = DateTime.Now;
            return result;
        }
        public List<T> GetQueryResult<T>(string queryName, List<IDataParameter> cparams = null)
        {
            string queryText = GetQueryText(queryName);
            return GetQueryResultDirect<T>(queryText, cparams);

        }
        public List<T> GetQueryResult<T>(int queryId, List<IDataParameter> cparams = null)
        {
            string queryText = GetQueryText(queryId);
            queryText = RemoveUnsetParameters(queryText, cparams);
            return GetQueryResultDirect<T>(queryText, cparams);

        }

        public int InsertObject<T>(T obj) where T : class
        {
            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            try
            {
                using (con = new NpgsqlConnection(conStr))
                {
                    con.Open();
                    return (int)con.InsertPg<T>(obj);
                }
            }
            catch (Exception ex)
            {
                ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                tm2 = DateTime.Now;
                span = tm2 - tm;
                ql.ExecutionTime = tm;
                ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                ql.QueryName = typeof(T).FullName;
                CreateQueryLog(ql);
                throw ex;
            }
        }
        public int InsertObject<T>(T obj, NpgsqlConnection con) where T : class
        {
            return (int)con.InsertPg<T>(obj);
        }

        public void DeleteObject<T>(T obj) where T : class
        {
            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            try
            {
                using (con = new NpgsqlConnection(conStr))
                {
                    con.Open();
                    con.Delete<T>(obj);
                }
            }
            catch (Exception ex)
            {
                ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                tm2 = DateTime.Now;
                span = tm2 - tm;
                ql.ExecutionTime = tm;
                ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                ql.QueryName = typeof(T).FullName;
                CreateQueryLog(ql);
                throw ex;
            }
        }

        public int UpdateObject<T>(T obj)
        {
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                return con.UpdatePg<T>(obj);
            }
        }

        //public IDataReader ExecuteReader(List)
        //{

        //}
        RestClient client;
        public DataTable GetQueryResultWeb(string queryname, List<IDataParameter> parameters)
        {
            if (url != "" && workFromWeb)
            {
                client = new RestClient(url);
                var request = new RestRequest("Api/App/GetDataTable?queryname=" + queryname, Method.POST);
                request.AddHeader("Authorization", this.accesskey);

                request.AddJsonBody(parameters);
                IRestResponse res = client.Execute(request);

                return JsonHelper.Instance.DeserializeObject<DataTable>(res.Content);
            }
            return null;
        }
        public DataTable GetQueryResultWebDirect(string queryText, List<CustomParameter> parameters)
        {
            client = new RestClient(url);
            var request = new RestRequest("Api/App/GetDataTableDirect?querytext=" + queryText, Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            if (parameters != null)
            {
                request.AddJsonBody(parameters);

            }
            IRestResponse res = client.Execute(request);

            return JsonHelper.Instance.DeserializeObject<DataTable>(res.Content);
        }
        public DataTable GetQueryResultDataTable(int queryId, List<IDataParameter> parameters)
        {
            DataTable result = new DataTable();
            string queryText = GetQueryText(queryId);
            queryText = RemoveUnsetParameters(queryText, parameters);
            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            try
            {
                using (con = new NpgsqlConnection(conStr))
                {
                    con.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand();
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {

                            cmd.Parameters.AddWithValue(item.ParameterName, item.Value);
                        }
                    }
                    cmd.Connection = con;
                    cmd.CommandText = queryText;
                    cmd.CommandTimeout = 200;
                    NpgsqlDataAdapter adap = new NpgsqlDataAdapter(cmd);
                    adap.Fill(result);
                    tm2 = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                tm2 = DateTime.Now;
                span = tm2 - tm;
                ql.ExecutionTime = tm;
                ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                ql.QueryName = queryId.ToString();
                ql.QueryText = queryText;
                CreateQueryLog(ql);
                throw ex;
            }


            return result;
        }
        public DataTable GetQueryResultDataTable(string queryName, List<IDataParameter> parameters)
        {

            DataTable result = new DataTable();
            string queryText = GetQueryText(queryName);
            if (string.IsNullOrEmpty(queryText))
            {
                throw new Exception(queryName + " doesn't found on appquery table. Be careful about the case sensitivity.");
            }
            queryText = RemoveUnsetParameters(queryText, parameters);
            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            try
            {
                using (con = new NpgsqlConnection(conStr))
                {
                    con.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand();
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {

                            cmd.Parameters.AddWithValue(item.ParameterName, item.Value);
                        }
                    }
                    cmd.Connection = con;
                    cmd.CommandText = queryText;
                    cmd.CommandTimeout = 200;
                    NpgsqlDataAdapter adap = new NpgsqlDataAdapter(cmd);
                    adap.Fill(result);
                    tm2 = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                tm2 = DateTime.Now;
                span = tm2 - tm;
                ql.ExecutionTime = tm;
                ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                ql.QueryName = queryName;
                ql.QueryText = queryText;
                CreateQueryLog(ql);
                throw ex;
            }
            return result;
        }
        public DataTable GetQueryResultDataTableDirect(string queryText, List<IDataParameter> parameters)
        {

            DataTable result = new DataTable();
            if (string.IsNullOrEmpty(queryText))
            {
                throw new Exception("query text must not be empty !");
            }
            queryText = RemoveUnsetParameters(queryText, parameters);
            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            try
            {
                using (con = new NpgsqlConnection(conStr))
                {
                    con.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand();
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {

                            cmd.Parameters.AddWithValue(item.ParameterName, item.Value);
                        }
                    }
                    cmd.Connection = con;
                    cmd.CommandText = queryText;
                    cmd.CommandTimeout = 200;
                    NpgsqlDataAdapter adap = new NpgsqlDataAdapter(cmd);
                    adap.Fill(result);
                    tm2 = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                tm2 = DateTime.Now;
                span = tm2 - tm;
                ql.ExecutionTime = tm;
                ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                ql.QueryName = "Custom";
                ql.QueryText = queryText;
                CreateQueryLog(ql);
                throw ex;
            }


            return result;
        }
        public int ExecuteQueryWeb(string queryName, List<CustomParameter> parameters)
        {


            client = new RestClient(url);
            var request = new RestRequest("api/App/ExecuteQuery?querytext=" + queryName, Method.POST);
            request.AddHeader("Authorization", this.accesskey);

            if (parameters != null)
            {
                request.AddJsonBody(parameters);

            }
            IRestResponse resp = client.Execute(request);
            ServiceResponse<int> sr = SimpleJson.DeserializeObject<ServiceResponse<int>>(resp.Content);
            if (sr.ResponseCode == 1)
            {
                return sr.ResponseObject;
            }
            else
            {
                throw new Exception(sr.ResponseMessage);
            }


        }

        public int ExecuteQuery(string queryName, object parameters = null)
        {
            int res = 0;

            string queryText = GetQueryText(queryName);
            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();

            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                try
                {
                    res = con.Execute(queryText, parameters);
                    tm2 = DateTime.Now;

                }
                catch (Exception ex)
                {
                    ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                    tm2 = DateTime.Now;
                    throw ex;
                }
                finally
                {
                    span = tm2 - tm;
                    ql.ExecutionTime = tm;
                    ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                    ql.QueryName = queryName;
                    ql.QueryText = queryText;



                    CreateQueryLog(ql);
                }
            }


            return res;
        }
        public int ExecuteQueryTextWithTimeout(int timeout, string queryText, object parameters = null)
        {

            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            int res = 0;
            using (con = new NpgsqlConnection(conStr))
            {

                con.Open();
                try
                {
                    res = con.Execute(queryText, parameters, null, timeout);
                    tm2 = DateTime.Now;

                }
                catch (Exception ex)
                {
                    ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                    tm2 = DateTime.Now;
                    span = tm2 - tm;
                    ql.ExecutionTime = tm;
                    ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                    ql.QueryName = "Custom";
                    ql.QueryText = queryText;
                    CreateQueryLog(ql);
                    throw ex;
                }

            }
            return res;
        }
        public int ExecuteQueryText(string queryText, object parameters = null)
        {

            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            int res = 0;
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                try
                {
                    res = con.Execute(queryText, parameters);
                    tm2 = DateTime.Now;

                }
                catch (Exception ex)
                {
                    ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                    tm2 = DateTime.Now;
                    span = tm2 - tm;
                    ql.ExecutionTime = tm;
                    ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                    ql.QueryName = "Custom";
                    ql.QueryText = queryText;
                    CreateQueryLog(ql);
                    throw ex;
                }

            }
            return res;
        }
        /// <summary>
        /// If you want to use an external connection. You can pass connection as a parameter.
        /// </summary>
        /// <param name="con"></param>
        /// <param name="queryText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int ExecuteQueryText(NpgsqlConnection con, string queryText, object parameters = null)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con.Execute(queryText, parameters);
        }
        public int ExecuteQueryText2(string queryText, List<CustomParameter> parameters = null)
        {

            TimeSpan span;
            DateTime tm = DateTime.Now;
            DateTime tm2 = DateTime.Now;
            AppQueryLog ql = new AppQueryLog();
            int res = 0;
            using (con = new NpgsqlConnection(conStr))
            {
                con.Open();
                try
                {
                    DynamicParameters dynParam = null;
                    if (parameters != null)
                    {
                        dynParam = new DynamicParameters();
                        foreach (var item in parameters)
                        {
                            dynParam.Add(item.ParameterName, item.Value);
                        }
                    }

                    res = con.Execute(queryText, dynParam);
                    tm2 = DateTime.Now;

                }
                catch (Exception ex)
                {
                    ql.ErrorMessage = (ex.Message + ex.StackTrace).Substring(0, 149);
                    tm2 = DateTime.Now;
                    span = tm2 - tm;
                    ql.ExecutionTime = tm;
                    ql.Duration = Convert.ToInt32(span.TotalMilliseconds);
                    ql.QueryName = "Custom";
                    ql.QueryText = queryText;
                    CreateQueryLog(ql);
                    throw ex;
                }

            }
            return res;
        }
        private void CreateQueryLog(AppQueryLog log)
        {
            //if (this.nolog == false)
            //{
            //    using (con = new NpgsqlConnection(conStr))
            //    {
            //        con.Open();
            //        con.InsertPg<AppQueryLog>(log);
            //    }
            //}

        }
        public static String RemoveUnsetParameters(String QueryText, List<IDataParameter> PrmList)
        {
            Int32 IssetBegin = 0;
            Int32 IssetEnd = 0;
            Int32 IssetClose = 0;
            String PrmName = String.Empty;
            Boolean PrmSupplied = false;

            while (QueryText.IndexOf(ISSET_BEGIN) > 0)
            {
                IssetBegin = QueryText.IndexOf(ISSET_BEGIN);
                IssetEnd = QueryText.IndexOf(ISSET_END, IssetBegin);
                IssetClose = QueryText.IndexOf(ISSET_CLOSE);

                if (IssetBegin > 0)
                {
                    if (IssetClose == -1)
                        throw new Exception("ISSET statement didn't closed properly");

                    PrmName = QueryText.Substring(IssetBegin + ISSET_BEGIN.Length, (IssetEnd - (IssetBegin + ISSET_BEGIN.Length)));
                    PrmName = PrmName.Trim(new Char[1] { ' ' });

                    PrmSupplied = false;

                    if (PrmList != null)
                    {
                        for (Int32 Idx = 0; Idx < PrmList.Count; Idx++)
                        {
                            if (PrmList[Idx].ParameterName == PrmName && PrmList[Idx].Value.ToString().Length > 0)
                            {
                                PrmSupplied = true;
                                break;
                            }
                        }
                    }



                    if (PrmSupplied)
                    {
                        QueryText = QueryText.Substring(0, IssetBegin) +
                                    QueryText.Substring(IssetEnd + ISSET_END.Length, IssetClose - IssetEnd - 1) +
                                    QueryText.Substring(IssetClose + ISSET_CLOSE.Length);
                    }
                    else
                    {
                        QueryText = QueryText.Substring(0, IssetBegin) +
                                    QueryText.Substring(IssetClose + ISSET_CLOSE.Length);
                    }
                }
            }

            return QueryText;
        }
        public List<IDataParameter> GetSingleParameter<T>(string key, T value)
        {
            List<IDataParameter> lst = new List<IDataParameter>();
            lst.Add(new CustomParameter { ParameterName = key, Value = value });
            return lst;
        }
        private class PropertyContainer
        {
            private readonly Dictionary<string, object> _ids;
            private readonly Dictionary<string, object> _values;

            #region Properties

            internal IEnumerable<string> IdNames
            {
                get { return _ids.Keys; }
            }

            internal IEnumerable<string> ValueNames
            {
                get { return _values.Keys; }
            }

            internal IEnumerable<string> AllNames
            {
                get { return _ids.Keys.Union(_values.Keys); }
            }

            internal IDictionary<string, object> IdPairs
            {
                get { return _ids; }
            }

            internal IDictionary<string, object> ValuePairs
            {
                get { return _values; }
            }

            internal IEnumerable<KeyValuePair<string, object>> AllPairs
            {
                get { return _ids.Concat(_values); }
            }

            #endregion

            #region Constructor

            internal PropertyContainer()
            {
                _ids = new Dictionary<string, object>();
                _values = new Dictionary<string, object>();
            }

            #endregion

            #region Methods

            internal void AddId(string name, object value)
            {
                _ids.Add(name, value);
            }

            internal void AddValue(string name, object value)
            {
                _values.Add(name, value);
            }

            #endregion
        }

        public int ExecuteDirectFromWS(string querytext, List<CustomParameter> paramlist = null)
        {
            client = new RestClient(url);
            var request = new RestRequest("api/App/ExecuteQueryDirect?querytext=" + querytext, Method.POST);
            request.AddHeader("Authorization", this.accesskey);

            if (paramlist != null)
            {
                request.AddJsonBody(paramlist);
            }
            IRestResponse res = client.Execute(request);
            ServiceResponse<int> sr = SimpleJson.DeserializeObject<ServiceResponse<int>>(res.Content);
            if (sr.ResponseCode == 1)
            {
                return sr.ResponseObject;
            }
            else
            {
                throw new Exception(sr.ResponseMessage);
            }
        }

    }


}
