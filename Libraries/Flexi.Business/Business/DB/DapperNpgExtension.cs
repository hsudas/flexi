using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Npgsql;
using Dapper.Contrib.Extensions;

namespace Flexi.Business.Business.DB.Ext
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DapperKey : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class DapperIgnore : Attribute
    {
    }

    public static class DapperNpgExtension
    {
        // private readonly string _connectionString;

        #region Constructor

        //public DapperPostgreExtension(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        #endregion

        #region Standard Dapper functionality

        // Example: GetBySql<Activity>( "SELECT * 
        //FROM Activities WHERE Id = @activityId", new {activityId = 15} ).FirstOrDefault();
        public static IEnumerable<T> QueryPg<T>(this IDbConnection con, string sql, CommandType commandType, object parameters = null)
        {


            return con.Query<T>(sql, parameters, commandType: commandType);

        }




        //public NpgsqlConnection GetOpenConnection()
        //{
        //    var connection = new NpgsqlConnection(_connectionString);
        //    connection.Open();
        //    return connection;
        //}

        #endregion

        #region Automated methods for: Insert, Update, Delete

        // These methods are provided for your convenience.
        // For simple objects they will work fine, 
        // but please be aware that they will not cover more complex scenarios!
        // Id column is assumed to be of type int IDENTITY.
        // Reflection is used to create appropriate SQL statements.
        // Even if reflection is costly in itself, the average gain 
        // compared to Entity Framework is approximately a factor 10!
        // Key property is determined by convention 
        // (Id, TypeNameId or TypeName_Id) or by custom attribute [DapperKey].
        // All properties with public setters are included. 
        // Exclusion can be manually made with custom attribute [DapperIgnore].
        // If key property is mapped to single database Identity column, 
        // then it is automatically reflected back to object.

        //
        /// <summary>
        /// Automatic generation of SELECT statement, BUT only for simple equality criterias!
        /// Example: Select<LogItem>(new {Class = "Client"})
        /// For more complex criteria it is necessary to call GetItems method with custom SQL statement.
        /// </summary>
        //public IEnumerable<T> Select<T>(object criteria = null)
        //{
        //    var properties = ParseProperties(criteria);
        //    var sqlPairs = GetSqlPairs(properties.AllNames, " AND ");
        //    var sql = string.Format("SELECT * FROM [{0}] WHERE {1}", typeof(T).Name, sqlPairs);
        //    return GetItems<T>(CommandType.Text, sql, properties.AllPairs);
        //}

        public static long InsertPg<T>(this IDbConnection con, T obj, IDbTransaction tran = null, string keyColumn = null)
        {
            string tableName = CheckTableAttribute<T>(obj);

            var propertyContainer = ParseProperties(obj);
            string idField = propertyContainer.IdPairs.First().Key;
            var sql = string.Format("INSERT INTO {0} ({1})    VALUES (@{2}) RETURNING " + idField.ToLower().Replace("ı", "i"), tableName,
                string.Join(", ", propertyContainer.ValueNames).ToLower(),
                string.Join(", @", propertyContainer.ValueNames).ToLower());
            long id = 0;
            id = con.Query<int>(sql, propertyContainer.ValuePairs, tran).First();


            return id;
        }

        public static int UpdatePg<T>(this IDbConnection con, T obj, IDbTransaction tran = null)
        {
            string tableName = CheckTableAttribute<T>(obj);
            var propertyContainer = ParseProperties(obj);
            var sqlIdPairs = GetSqlPairs(propertyContainer.IdNames);
            var sqlValuePairs = GetSqlPairs(propertyContainer.ValueNames);
            var sql = $"UPDATE {tableName}  SET {sqlValuePairs.ToLower()} WHERE {sqlIdPairs.ToLower()}";
            return con.Execute(sql, propertyContainer.AllPairs, tran);

        }

        //public void Delete<T>(T obj, IDbTransaction tran = null)
        //{
        //    var propertyContainer = ParseProperties(obj);
        //    var sqlIdPairs = GetSqlPairs(propertyContainer.IdNames);
        //    var sql = string.Format("DELETE FROM {0}   WHERE {1}", typeof(T).Name, sqlIdPairs);
        //    Execute(sql, propertyContainer.IdPairs,tran);
        //}

        #endregion

        #region Reflection support

        private static string CheckTableAttribute<T>(T obj)
        {
            string tableName = typeof(T).Name;
            System.Reflection.MemberInfo info = typeof(T);
            foreach (object attrib in info.GetCustomAttributes(true))
            {
                if (attrib.GetType() == typeof(Dapper.Contrib.Extensions.TableAttribute))
                {
                    Dapper.Contrib.Extensions.TableAttribute att = attrib as Dapper.Contrib.Extensions.TableAttribute;
                    tableName = att.Name;
                }

            }
            return tableName;
        }
        /// <summary>
        /// Retrieves a Dictionary with name and value 
        /// for all object properties matching the given criteria.
        /// </summary>
        private static PropertyContainer ParseProperties<T>(T obj)
        {
            var propertyContainer = new PropertyContainer();

            var typeName = typeof(T).Name;
            var validKeyNames = new[] { "Id",
                $"{typeName}Id", $"{typeName}_Id"
            };

            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                // Skip reference types (but still include string!)
                if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
                    continue;

                // Skip methods without a public setter
                if (property.GetSetMethod() == null)
                    continue;

                // Skip methods specifically ignored
                if (property.IsDefined(typeof(Dapper.Contrib.Extensions.ComputedAttribute), false))
                    continue;

                var name = property.Name;
                var value = typeof(T).GetProperty(property.Name).GetValue(obj, null);

                if (property.IsDefined(typeof(Dapper.Contrib.Extensions.KeyAttribute), false) || validKeyNames.Contains(name))
                {
                    propertyContainer.AddId(name, value);
                }
                else
                {
                    propertyContainer.AddValue(name, value);
                }
            }

            return propertyContainer;
        }

        /// <summary>
        /// Create a commaseparated list of value pairs on 
        /// the form: "key1=@value1, key2=@value2, ..."
        /// </summary>
        private static string GetSqlPairs
        (IEnumerable<string> keys, string separator = ", ")
        {
            var pairs = keys.Select(key => string.Format("{0}=@{0}", key)).ToList();
            return string.Join(separator, pairs);
        }

        private static void SetId<T>(T obj, int id, IDictionary<string, object> propertyPairs)
        {
            if (propertyPairs.Count == 1)
            {
                var propertyName = propertyPairs.Keys.First();
                var propertyInfo = obj.GetType().GetProperty(propertyName);
                if (propertyInfo.PropertyType == typeof(int))
                {
                    propertyInfo.SetValue(obj, id, null);
                }
            }
        }
        private static string GetKeyColumn<T>(T obj, int id, IDictionary<string, object> propertyPairs)
        {
            return propertyPairs.Keys.First();
        }
        #endregion

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
    }
}