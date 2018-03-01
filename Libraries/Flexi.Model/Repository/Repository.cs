using Flexi.Model.Repository.Interface;
using Dapper;
using Microsoft.Win32;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Flexi.Model.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public string ConnectionString { get; set; }

        protected IDbConnection Connection
        {
            get
            {
                //return new NpgsqlConnection(String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", "5432", "postgres", "123.54", "template1"));
                IDbConnection connection;
                if (string.IsNullOrEmpty(ConnectionString))
                {
                    try
                    {
                        connection = new NpgsqlConnection(this.ReadRegistry(@"Canyon", "DbContext"));//ConfigurationManager.ConnectionStrings["DBContext"].ConnectionString//

                    }
                    catch (Exception)
                    {

                        connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["DBContext"].ConnectionString);

                    }
                }
                else
                {
                    connection = new NpgsqlConnection(ConnectionString);
                }
                SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
                return connection;
            }
        }

        public virtual List<T> GetList()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                //return cn.GetList<T>(new { Status = 1, SiteId = siteId }).ToList();
                return cn.GetList<T>().ToList();
            }
        }

        public virtual IEnumerable<T> GetEnumerable()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                //return cn.GetList<T>(new { Status = 1, SiteId = siteId }).ToList();
                return cn.GetList<T>();
            }
        }

        public virtual List<T> GetList(Object whereConditions)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.GetList<T>(whereConditions).ToList();
            }
        }

        public virtual IEnumerable<T> GetEnumerable(Object whereConditions)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.GetList<T>(whereConditions);
            }
        }

        public virtual Task<IEnumerable<T>> GetListAsync()
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.GetListAsync<T>();
            }
        }

        public virtual Task<IEnumerable<T>> GetListAsync(Object whereConditions)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.GetListAsync<T>(whereConditions);
            }
        }

        public virtual List<T> GetList(string conditions, Object whereConditions)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.GetList<T>(conditions, whereConditions).ToList();
            }
        }

        public virtual IEnumerable<T> GetListWithPageNumber(int pageNumber, Object whereConditions, int rowsPerPage = 20)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.GetListPaged<T>(pageNumber, rowsPerPage, string.Empty, string.Empty, whereConditions).ToList();
            }
        }

        public virtual T Get(Object whereConditions)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.GetList<T>(whereConditions).FirstOrDefault();
            }
        }

        public virtual int GetRecordCount(string whereConditions)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.RecordCount<T>(whereConditions);
            }
        }

        public virtual int GetRecordCount(Object whereConditions)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.RecordCount<T>(whereConditions);
            }
        }

        //public virtual List<T> GetList(Object whereConditions)
        //{
        //    using (IDbConnection cn = Connection)
        //    {
        //        cn.Open();

        //        var a = whereConditions;
        //        var type = a.GetType();
        //        var props = type.GetProperties();
        //        var pairs = props.Select(t => "\"" + t.Name + "\"" + "='" + t.GetValue(a, null) + "'").ToArray();
        //        string mergedConditions = "where \"Status\" = 1 and \"SiteId\" = " + siteId;
        //        mergedConditions += " and " + string.Join(" and ", pairs);

        //        return cn.GetList<T>(mergedConditions).ToList();
        //    }
        //}

        public virtual List<T> GetWhere(string whereSql)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.GetList<T>(whereSql).ToList();
            }
        }

        public virtual int Add(T entity)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.Insert(entity) ?? 0;
            }
        }

        public virtual int Update(T entity)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.Update(entity);
            }
        }

        public virtual void Remove(int id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                cn.Delete<T>(id);
            }
        }

        public virtual void Remove(T entity)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                cn.Delete<T>(entity);
            }
        }

        public virtual void RemoveList(Object whereConditions)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                cn.DeleteList<T>(whereConditions);
            }
        }

        public virtual T GetById(int id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.Get<T>(id);
            }
        }

        public virtual List<T> Execute(string sql)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                //IDataReader reader = cn.ExecuteReader(sql);

                return null;
            }
        }

        public int ExecuteSQL(string sql)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                //IDataReader reader = cn.ExecuteReader(sql);
                return cn.Execute(sql);
            }
        }

        public object ExecuteScalar(string sql)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                //IDataReader reader = cn.ExecuteReader(sql);
                return cn.ExecuteScalar<object>(sql);
            }
        }

        public List<T> ExecuteQuery<T>(string sql)
        {
            List<T> list = null;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Dapper.SqlMapper.GridReader result = cn.QueryMultiple(sql);
                list = (List<T>)result.Read<T>();
            }

            return list;
        }

        public List<T> ExecuteQuery(string sql)
        {
            List<T> list = null;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Dapper.SqlMapper.GridReader result = cn.QueryMultiple(sql);
                list = (List<T>)result.Read<T>();
            }
            return list;
        }

        public virtual int? AddAsTransactional(T entity, IDbConnection conn, IDbTransaction transaction)
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
            return conn.Insert(entity, transaction);
        }

        public virtual int? UpdateAsTransactional(T entity, IDbConnection conn, IDbTransaction transaction)
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
            return conn.Update(entity, transaction);
        }

        public virtual int RemoveAsTransactional(T entity, IDbConnection conn, IDbTransaction transaction)
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
            int recordCount = conn.Delete<T>(entity, transaction);
            return recordCount;
        }

        public virtual int RemoveAsTransactional(int id, IDbConnection conn, IDbTransaction transaction)
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
            int recordCount = conn.Delete<T>(id, transaction);
            return recordCount;
        }

        public virtual int RemoveListAsTransactional(Object whereConditions, IDbConnection conn, IDbTransaction transaction)
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
            int recordCount = conn.DeleteList<T>(whereConditions, transaction);
            return recordCount;
        }

        //private string RegisteryRead(string path, string keyName)
        //{
        //    string keyValue = string.Empty;
        //    try
        //    {
        //        using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\" + path))
        //        {
        //            keyValue = registryKey.GetValue(keyName.ToUpper()).ToString();
        //            if (string.IsNullOrEmpty(keyValue))
        //            {
        //                keyValue = ReadRegistry(path, keyName);
        //            }
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //        keyValue = ReadRegistry(path, keyName);
        //    }
        //    return keyValue;
        //}

        //private string ReadRegistry(string path, string key)
        //{
        //    string value = string.Empty;
        //    try
        //    {
        //        using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
        //        using (var key1 = hklm.OpenSubKey(@"SOFTWARE\" + path))
        //        {
        //            value = key1.GetValue(key).ToString();
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //    }
        //    return value;
        //}

        public string ReadRegistry(string path, string key, RegistryView registryView = RegistryView.Default)
        {
            string value = string.Empty;
            try
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                using (var key1 = hklm.OpenSubKey(@"SOFTWARE\" + path))
                {
                    value = key1.GetValue(key).ToString();
                }
            }
            catch (Exception exc)
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, registryView))
                using (var key1 = hklm.OpenSubKey(@"SOFTWARE\" + path))
                {
                    value = key1.GetValue(key).ToString();
                }
            }
            return value;
        }
    }
}
