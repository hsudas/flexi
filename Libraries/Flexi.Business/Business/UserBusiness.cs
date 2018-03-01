using Flexi.Shared.Helper;
using Flexi.Model.Poco;
using Flexi.Model.Application;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Flexi.Business.Business
{
    public class UserBusiness
    {
        RestClient client;
        string url;
        string accesskey;
        public UserBusiness(string accesskey)
        {
            this.accesskey = accesskey;
            url = ConfigHelper.Instance.GetApiUrl();
        }


        public void Register(string userName, string password, string role)
        {
            client = new RestClient(url);
            var request = new RestRequest("api/account/register", Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            request.AddJsonBody(new { Email = userName, Password = password, ConfirmPassword = password, Role = role });
            IRestResponse response = client.Execute(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(response.Content);
            }
        }

        public void CreateRole(string roleName)
        {
            client = new RestClient(url);
            var request = new RestRequest("api/account/createrole?rolename=" + roleName, Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            //request.AddJsonBody(new { Email = userName, Password = password, ConfirmPassword = password, Role = role });
            IRestResponse response = client.Execute(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(response.Content);
            }
        }

        public ServiceResponse<AspNetRoles> SetRoleToUser(string user, string role)
        {
            client = new RestClient(url);
            var request = new RestRequest("api/account/setroletouser?username=" + user + "&rolename=" + role, Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            IRestResponse response = client.Execute(request);
            ServiceResponse<AspNetRoles> sr = SimpleJson.DeserializeObject<ServiceResponse<AspNetRoles>>(response.Content);
            return sr;
        }
        public ServiceResponse<AspNetUsers> SetPassword(string username, string password)
        {
            client = new RestClient(url);
            var request = new RestRequest("api/account/SetUserPassword?username=" + username + "&password=" + password, Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            IRestResponse response = client.Execute(request);
            ServiceResponse<AspNetUsers> sr = SimpleJson.DeserializeObject<ServiceResponse<AspNetUsers>>(response.Content);
            return sr;
        }

        public ServiceResponse<AspNetUsers> DeleteUser(string username)
        {
            client = new RestClient(url);
            var request = new RestRequest("api/account/DeleteUser?username=" + username, Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            IRestResponse response = client.Execute(request);
            ServiceResponse<AspNetUsers> sr = SimpleJson.DeserializeObject<ServiceResponse<AspNetUsers>>(response.Content);
            return sr;
        }

        public List<AspNetUsers> GetAllUser()
        {
            ServiceResponse<AspNetUsers> sr = new ServiceResponse<AspNetUsers>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/Account/getalluser");
            request.Headers.Add("Authorization", this.accesskey);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            sr = JsonHelper.Instance.DeserializeFromStream<ServiceResponse<AspNetUsers>>(responseStream);
            if (sr.ResponseCode == 0)
            {
                throw new Exception(sr.ResponseMessage);
            }

            return sr.ResponseList;

        }
        public ServiceResponse<AspNetUsers> GetUser(string id)
        {
            ServiceResponse<AspNetUsers> sr = new ServiceResponse<AspNetUsers>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/Account/getuser?userName=" + id);
            request.Headers.Add("Authorization", this.accesskey);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            sr = JsonHelper.Instance.DeserializeFromStream<ServiceResponse<AspNetUsers>>(responseStream);

            return sr;

        }
        public ServiceResponse<AspNetRoles> GetAllRoles()
        {
            ServiceResponse<AspNetRoles> sr = new ServiceResponse<AspNetRoles>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/Account/GetAllRoles");
            request.Headers.Add("Authorization", this.accesskey);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            sr = JsonHelper.Instance.DeserializeFromStream<ServiceResponse<AspNetRoles>>(responseStream);

            return sr;

        }

        public void Logout()
        {
            client = new RestClient(url);
            var request = new RestRequest("api/Account/Logout", Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            IRestResponse response = client.Execute(request);
        }



    }
}
