using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

namespace Flexi.Shared.Helper
{
    public class JsonHelper
    {
        private static readonly Lazy<JsonHelper> lazy = new Lazy<JsonHelper>(() => new JsonHelper());
        public static JsonHelper Instance { get { return lazy.Value; } }
        private JsonHelper()
        {
        }

        public string SerializeObject(object obj)
        {
            return JsonConvert.SerializeObject(obj).Replace(@"\", " ");
        }

        public string SerializeObject(object obj, bool camelCase = false, bool indented = false)
        {
            var options = new JsonSerializerSettings();
            if (camelCase)
            {
                options.ContractResolver = new CamelCasePropertyNamesContractResolver();
            }
            if (indented)
            {
                options.Formatting = Formatting.Indented;
            }
            return JsonConvert.SerializeObject(obj).Replace(@"\", " ");
        }

        public string SerializeObjectWithFormatting(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented).Replace(@"\", "");
        }

        public T DeserializeObject<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        public T DeserializeObject<T>(object obj)
        {
            return this.DeserializeObject<T>(SerializeObject(obj));
        }

        public T DeserializeFromStream<T>(Stream str)
        {
            StreamReader sr = new StreamReader(str);
            string jstring = sr.ReadToEnd();
            return JsonConvert.DeserializeObject<T>(jstring);
        }

        public string SerializeObjectWithoutNullValue(object obj)
        {
            string value = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            return value;
        }

        public static T DeserializeFromString<T>(string str, bool ignoreNullValues)
        {
            return JsonConvert.DeserializeObject<T>(str,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
        }

        public string EnumToJson(Type enumType)
        {
            var enumVals = new List<object>();
            foreach (var item in Enum.GetValues(enumType))
            {
                enumVals.Add(new
                {
                    Id = (int)item,
                    Name = item.ToString()
                });
            }
            string strJson = SerializeObject(enumVals);
            return strJson;
        }
    }
}
