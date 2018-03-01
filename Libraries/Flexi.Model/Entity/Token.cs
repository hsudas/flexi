using RestSharp;
using System;
using System.Configuration;

namespace Flexi.Model.Security
{

    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string url { get; set; }
        public string expires_in { get; set; }
        public string userName { get; set; }
        public string roles { get; set; }
        public DateTime ExpireDate { get; set; }

        public string Content { get; set; }
        private string accessKey;
        public string AccessKey
        {

            get { return "bearer " + access_token; }
            set { accessKey = value.Replace("bearer ", ""); }
        }

        public string[] RoleName
        {
            get { return roles.Split(','); }
        }
        /// <summary>
        /// server'a login olup. geçerli bir token alır.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Token GetToken(string username, string password)
        {
            string url = ConfigurationManager.AppSettings["apiurl"];
            RestClient client = new RestClient(url);
            var request = new RestRequest("Token", Method.POST);
            string loginStr = "grant_type=password&username=" + username + "&password=" + password;
            request.AddParameter("application/x-www-form- urlencoded", loginStr, ParameterType.RequestBody);
            IRestResponse<Token> resp = client.Execute<Token>(request);
            Token token = resp.Data;
            if (resp.Data != null)
            {
                token.Content = resp.Content;
            }
            if (token != null)
            {
                if (token.expires_in != null)
                {
                    //expires_in parametresi token'ın kaç saniye geçerli olacağını tutuyor.
                    //token alması en fazla 3 saniye sürse. üç saniye çıkarıp şimdiki tarihe eklediğimde
                    //token'ın ne kadar süre geçerli olacağını buluyorum.
                    token.ExpireDate = DateTime.Now.AddSeconds(Convert.ToInt64(token.expires_in) - 3);
                }
            }
            return token;
        }

        public static Token GetToken(string username, string password, string apiurl)
        {
            string url = apiurl;
            RestClient client = new RestClient(url);
            var request = new RestRequest("Token", Method.POST);
            string loginStr = "grant_type=password&username=" + username + "&password=" + password;
            request.AddParameter("application/x-www-form- urlencoded", loginStr, ParameterType.RequestBody);
            IRestResponse<Token> resp = client.Execute<Token>(request);
            Token token = resp.Data;
            if (resp.Data != null)
            {
                token.Content = resp.Content;
            }
            if (token != null)
            {
                if (token.expires_in != null)
                {
                    //expires_in parametresi token'ın kaç saniye geçerli olacağını tutuyor.
                    //token alması en fazla 3 saniye sürse. üç saniye çıkarıp şimdiki tarihe eklediğimde
                    //token'ın ne kadar süre geçerli olacağını buluyorum.
                    token.ExpireDate = DateTime.Now.AddSeconds(Convert.ToInt64(token.expires_in) - 3);
                }
            }
            return token;
        }
    }
}
