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
    public class MenuBusiness
    {
        string url;
        string accesskey;
        public MenuBusiness(string accesskey)
        {
            this.accesskey = accesskey;
            url = ConfigHelper.Instance.GetApiUrl();
        }
        public List<AppMenu> GetAllMenu(int applicationId)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/menu/getallmenu?applicationId=" + applicationId);
            request.Headers.Add("Authorization", this.accesskey);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            return JsonHelper.Instance.DeserializeFromStream<List<AppMenu>>(responseStream);
        }
        public List<AppMenu> GetAuthorizedMenu(string roleName)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/menu/GetAuthorizedMenu?roleName=" + roleName);
            request.Headers.Add("Authorization", this.accesskey);
            WebResponse response;
            try
            {
                response = request.GetResponse();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            Stream responseStream = response.GetResponseStream();
            return JsonHelper.Instance.DeserializeFromStream<List<AppMenu>>(responseStream);
        }
        public ServiceResponse<AppMenu> GetUserMenuByUser(string userId)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/Menu/GetUserMenu?userid=" + userId);
            request.Headers.Add("Authorization", this.accesskey);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            return JsonHelper.Instance.DeserializeFromStream<ServiceResponse<AppMenu>>(responseStream);
        }
        public ServiceResponse<AppMenu> GetRoleMenuByRole(string roleId)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/Menu/GetRoleMenu?roleid=" + roleId);
            request.Headers.Add("Authorization", this.accesskey);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            return JsonHelper.Instance.DeserializeFromStream<ServiceResponse<AppMenu>>(responseStream);
        }
        RestClient client;
        public void CreateAppMenuUser(AppMenuUser menuUser)
        {
            client = new RestClient(url);
            var request = new RestRequest("Api/Menu/SetUserMenu", Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            request.AddJsonBody(menuUser);
            IRestResponse response = client.Execute(request);
            ServiceResponse<AppMenuUser> sr = SimpleJson.DeserializeObject<ServiceResponse<AppMenuUser>>(response.Content);
            if (sr.ResponseCode == 0)
            {
                throw new Exception(sr.ResponseMessage);
            }
        }
        public void RemoveAppMenuUser(AppMenuUser menuUser)
        {
            client = new RestClient(url);
            var request = new RestRequest("Api/Menu/RemoveUserMenu", Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            request.AddJsonBody(menuUser);
            IRestResponse response = client.Execute(request);
            ServiceResponse<AppMenuUser> sr = SimpleJson.DeserializeObject<ServiceResponse<AppMenuUser>>(response.Content);
            if (sr.ResponseCode == 0)
            {
                throw new Exception(sr.ResponseMessage);
            }
        }
        public void CreateAppMenuRole(AppMenuRole menurole)
        {
            client = new RestClient(url);
            var request = new RestRequest("Api/Menu/SetRoleMenu", Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            request.AddJsonBody(menurole);
            IRestResponse response = client.Execute(request);
            ServiceResponse<AppMenuRole> sr = SimpleJson.DeserializeObject<ServiceResponse<AppMenuRole>>(response.Content);
            if (sr.ResponseCode == 0)
            {
                throw new Exception(sr.ResponseMessage);
            }
        }
        public void RemoveAppMenuRole(AppMenuRole menurole)
        {
            client = new RestClient(url);
            var request = new RestRequest("Api/Menu/RemoveRoleMenu", Method.POST);
            request.AddHeader("Authorization", this.accesskey);
            request.AddJsonBody(menurole);
            IRestResponse response = client.Execute(request);
            ServiceResponse<AppMenuRole> sr = SimpleJson.DeserializeObject<ServiceResponse<AppMenuRole>>(response.Content);
            if (sr.ResponseCode == 0)
            {
                throw new Exception(sr.ResponseMessage);
            }
        }

    }
}
