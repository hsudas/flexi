using Flexi.Shared.Helper;
using Flexi.Model.Enum;
using Flexi.Model.Poco;
using Flexi.Model;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Flexi.Business.Business
{
    public class WebApiInvoker
    {
        string accesskey = string.Empty;
        string apiUrl = string.Empty;
        public WebApiInvoker(string accesskey)
        {
            this.accesskey = accesskey;
        }
        public WebApiInvoker(string accesskey, string url)
        {
            this.accesskey = accesskey;
            apiUrl = url;
        }
        /// </summary>
        /// <param name="typeName">Çağıralacak metodun bulunduğu dll ismi. örn: Royal.Operation</param>
        /// <param name="typeName">Çağıralacak class. Namespace ile birlikte yazılacak. örn: Royal.Operation.AsinBusiness</param>
        /// <param name="methodName">Çağıralacak metod. Sadece metod ismi. Örn: GetAsins()</param>
        /// <param name="methodType">Static metodları çağırmak için Static. Instance oluşturup çağırılan metodlar için Standard.</param>
        /// <param name="arguments">metoda gönderilecek parametreler.</param>
        /// <returns>object döner, null döner. gün gelir hesap döner....</returns>
        public T InvokeMethod<T>(string assemblyName, string typeName, string methodName, MethodType methodType, Object[] arguments)
        {
            string url = ConfigHelper.Instance.GetApiUrl();
            if (apiUrl != string.Empty)
            {
                url = apiUrl;
            }
            RestClient client = new RestClient(url);
            var request = new RestRequest("api/App/Invoker", Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            List<Criteria> parameters = new List<Criteria>();
            parameters.Add(new Criteria { Key = "TypeName", Value = typeName });
            parameters.Add(new Criteria { Key = "AssemblyName", Value = assemblyName });
            parameters.Add(new Criteria { Key = "MethodName", Value = methodName });
            parameters.Add(new Criteria { Key = "MethodType", Value = methodType.ToString() });
            parameters.Add(new Criteria { Key = "Arguments", Value = arguments });
            request.AddJsonBody(parameters);
            IRestResponse response = client.Execute(request);
            //  ServiceResponse<object> sr = SimpleJson.DeserializeObject<ServiceResponse<object>>(res.Content);
            //ServiceResponse<object> sr = new RestSharp.Deserializers.JsonDeserializer().Deserialize<ServiceResponse<object>>(res); //             
            ServiceResponse<Object> serviceResponse2 = JsonHelper.Instance.DeserializeObject<ServiceResponse<Object>>(response.Content);
            if (serviceResponse2.ResponseCode == 1)
            {
                if (serviceResponse2.ResponseObject == null)
                {
                    return (T)Convert.ChangeType(serviceResponse2.ResponseObject, typeof(T));
                }
                string jsonString = serviceResponse2.ResponseObject.ToString();
                try
                {
                    T xx = JsonHelper.Instance.DeserializeObject<T>(jsonString);
                    return xx;
                }
                catch (Newtonsoft.Json.JsonReaderException)
                {
                    return (T)Convert.ChangeType(serviceResponse2.ResponseObject, typeof(T));
                }
            }
            else
            {
                throw new Exception(serviceResponse2.ResponseMessage);
            }
        }
    }
}