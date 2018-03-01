using Flexi.Shared.Extension;
using Newtonsoft.Json.Serialization;
using StackExchange.Redis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Flexi.Shared.Helper
{
    public class CacheHelper
    {
        private static readonly Lazy<CacheHelper> lazy = new Lazy<CacheHelper>(() => new CacheHelper());
        public static CacheHelper Instance { get { return lazy.Value; } }
        ConnectionMultiplexer connectionMultiplexer;

        private CacheHelper()
        {
            Connect();
        }

        private void Connect()
        {
            string redisDBHost = ConfigHelper.Instance.GetRedisDBHost();
            string redisDBPassword = ConfigHelper.Instance.GetRedisDBPassword();
            connectionMultiplexer = ConnectionMultiplexer.Connect($"{redisDBHost},password={redisDBPassword},ConnectTimeout=10000");
        }

        public void Set<T>(string key, T objectToCache, DateTime expireDate)
        {
            var expireTimeSpan = expireDate.Subtract(DateTime.Now);
            //connectionMultiplexer.GetDatabase().StringSet(key, JsonHelper.Instance.SerializeObject(objectToCache), expireTimeSpan);
            connectionMultiplexer.GetDatabase().StringSet(key, objectToCache.ToJson());
        }

        public void Set<T>(string key, T objectToCache)
        {
            connectionMultiplexer.GetDatabase().StringSet(key, objectToCache.ToJson());
        }

        public T GetHash<T>(string key1, string key2)
        {
            var redisObject = connectionMultiplexer.GetDatabase().HashGet(key1, key2);
            return redisObject.HasValue ? JsonHelper.Instance.DeserializeObject<T>(redisObject) : Activator.CreateInstance<T>();
        }

        public List<T> GetHashAll<T>(string key1)
        {
            HashEntry[] redisObject = connectionMultiplexer.GetDatabase().HashGetAll(key1);
            //object[] objArr = new object[100];
            //int i = 0;
            //foreach (var item in redisObject)
            //{
            //    objArr[i] = item.Value;
            //    Console.WriteLine(string.Format("key : {0}, value : {1}", item.Name, item.Value));
            //    i++;
            //}
            //var dataDict = redisObject.ToDictionary().Values.ToList();
            ////var arrayOfObjects;
            ////foreach (var data in dataDict)
            ////{
            ////    arrayOfObjects.
            ////}


            //JsonSerializerSettings settings = new JsonSerializerSettings();
            //settings.ContractResolver = new DictionaryAsArrayResolver();

            //string json = JsonConvert.SerializeObject(dataDict);

            //var arrayOfObjects = JsonConvert.SerializeObject(
            //    new[] { JsonConvert.DeserializeObject(dataDict[0]), JsonConvert.DeserializeObject(dataDict[1]) }
            //);
            //object[] objectArr = new object[1];

            //int[] terms = new int[400];
            //for (int i = 0; i < 400; i++)
            //{
            //    objectArr[i] = dataDict[i];
            //}
            //var cc = JsonConvert.SerializeObject(objectArr);
            //var cc2 = JsonConvert.SerializeObject(arrayOfObjects);//var aee = JsonHelper.Instance.DeserializeObject<T>(arrayOfObjects);
            //var a = JsonHelper.Instance.DeserializeObject<List<T>>(arrayOfObjects);
            //return JsonHelper.Instance.DeserializeObject<List<T>>(redisObject);
            List<T> list = new List<T>();
            foreach (var item in redisObject)
            {
                list.Add(JsonHelper.Instance.DeserializeObject<T>(item.Value));
            }
            return list;

        }

        public class DictionaryAsArrayResolver : DefaultContractResolver
        {
            protected override JsonContract CreateContract(Type objectType)
            {
                if (objectType.GetInterfaces().Any(i => i == typeof(IDictionary) ||
                   (i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IDictionary<,>))))
                {
                    return base.CreateArrayContract(objectType);
                }

                return base.CreateContract(objectType);
            }
        }

        public void SetHash<T>(string key1, string key2, T objectToCache)
        {
            connectionMultiplexer.GetDatabase().HashSet(key1, key2, JsonHelper.Instance.SerializeObject(objectToCache));

        }

        public void DeleteHash<T>(string key1, string key2, T objectToCache)
        {
            connectionMultiplexer.GetDatabase().HashDelete(key1, key2);
        }

        public void Set1<T>(string key, List<T> objectListToCache)
        {
            connectionMultiplexer.GetDatabase().StringSet(key, JsonHelper.Instance.SerializeObject(objectListToCache));
        }

        public static void SetList<T>(string key, List<T> list)
        {
            //connectionMultiplexer.GetDatabase().HashSet()
            //Set1<T>(key, list);
        }

        public T Get<T>(string key)
        {
            var redisObject = connectionMultiplexer.GetDatabase().StringGet(key);
            return redisObject.HasValue ? JsonHelper.Instance.DeserializeObject<T>(redisObject) : Activator.CreateInstance<T>();
        }

        public IEnumerable<T> GetList<T>(string key)
        {
            var redisObject = connectionMultiplexer.GetDatabase().StringGet(key);
            return redisObject.HasValue ? JsonHelper.Instance.DeserializeObject<IEnumerable<T>>(redisObject) : Activator.CreateInstance<IEnumerable<T>>();
        }

        public void SetList<T>(string key, IEnumerable<T> objectToCache)
        {
            connectionMultiplexer.GetDatabase().StringSet(key, objectToCache.ToJson());
        }

        //public Setting GetSetting<Setting>(string institution)
        //{
        //    var redisObject = connectionMultiplexer.GetDatabase().HashGet("setting", new RedisValue() {);
        //    return redisObject.HasValue ? JsonHelper.Instance.DeserializeObject<Setting>(redisObject) : Activator.CreateInstance<Setting>();
        //}

        public void Delete(string key)
        {
            connectionMultiplexer.GetDatabase().KeyDelete(key);
        }

        public bool Exists(string key)
        {
            return connectionMultiplexer.GetDatabase().KeyExists(key);
        }


        public void Dispose()
        {
            connectionMultiplexer.Dispose();
        }

    }
}
