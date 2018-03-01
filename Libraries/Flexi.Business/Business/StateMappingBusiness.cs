using Flexi.Shared.Helper;
using Flexi.Model.Entity;
using Flexi.Model.Poco;
using Flexi.Model.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Flexi.Business.Business
{
    public class StateMappingBusiness : BusinessBase
    {

        string url;
        string accesskey;
        bool isDbConnection = false;
        string conStr = "";
        public StateMappingBusiness(string accessKey)
        {
            this.accesskey = accessKey;
            url = ConfigHelper.Instance.GetApiUrl();
        }
        public StateMappingBusiness(string conStr, bool isDbConnection)
        {

        }
        public StateMapping GetStateMapping(string statename)
        {
            if (isDbConnection)
            {
                StateMappingRepository stateRep = new StateMappingRepository();
                List<StateMapping> lst = stateRep.GetWhere("WHERE lower(name)='" + statename.ToLower() + "'");
                if (lst.Count > 0)
                {
                    return lst[0];
                }
                else
                {
                    return null;
                }
            }
            else
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "Api/StateMapping/GetStateMapping?statename=" + statename);
                request.Headers.Add("Authorization", this.accesskey);
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                ServiceResponse<StateMapping> sr = JsonHelper.Instance.DeserializeFromStream<ServiceResponse<StateMapping>>(responseStream);
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
        /// <summary>
        /// returns state code and state name
        /// </summary>
        /// <returns>state code, state name</returns>
        public Dictionary<string, string> GetStateDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            StateMappingRepository stateRep = new StateMappingRepository();
            List<StateMapping> lst = stateRep.GetList();
            if (lst.Count > 0)
            {
                foreach (var item in lst)
                {
                    dict.Add(item.Name, item.Code);
                }
            }

            return dict;
        }
    }
}
