using Flexi.Model.Enum;
using System;
using System.Configuration;
using System.IO;

namespace Flexi.Shared.Helper
{
    public class ConfigHelper
    {
        private static readonly Lazy<ConfigHelper> lazy = new Lazy<ConfigHelper>(() => new ConfigHelper());
        public static ConfigHelper Instance { get { return lazy.Value; } }

        private ConfigHelper()
        {
        }

        public string GetDBContext()
        {
            
             return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            
        }

       

        public string GetApiUrl()
        {
            //string availableApiUrl = GetValue("apiurl");
            //System.Net.WebClient client = new System.Net.WebClient();
            //try
            //{
            //    string result = client.DownloadString(availableApiUrl);
            //    if (!result.Contains("This application includes"))
            //    {
            //        availableApiUrl = GetValue("apiurl2");
            //    }
            //}
            //catch (Exception exc)
            //{
            //    Logger.Error("GetApiUrl error!", exc);
            //    availableApiUrl = GetValue("apiurl2");
            //}
            //return availableApiUrl;
            return "http://service.royalqg.com/";// "http://life62.royalqg.com/";//"http://localhost:55135/";//
        }

       

        public string GetAwsSqsAccessKeyId()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsSqsAccessKeyId");
        }

        public string GetAwsSqsSecretAccessKey()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsSqsSecretAccessKey");
        }

        public string GetAmazonSellerId()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AmazonSellerId");
        }

        public string GetAmazonTokenName()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AmazonTokenName");
        }

        public string GetAmazonTokenPass()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AmazonTokenPass");
        }

        public string GetAwsAccessKey()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsAccessKey");
        }

        public string GetAwsSecretKey()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsSecretKey");
        }

        public string GetAwsSqsNotificationUrl()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsSqsNotificationUrl");
        }

        public string GetAwsSqsPriceUrl()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsSqsPriceUrl");
        }

        public string GetUserAgentHeader()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "UserAgentHeader");
        }

        public string GetAwsAssociateTag()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsAssociateTag");
        }

        public string GetAwsItemServiceUrl()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsItemServiceUrl");
        }

        public string GetAwsAccessKeyFromAssociate()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsAccessKeyFromAssociate");
        }

        public string GetAwsSecretKeyFromAssociate()
        {
            return RegistryHelper.Instance.ReadForWebApi(@"Canyon\Amazon", "AwsSecretKeyFromAssociate");
        }

        public EnvironmentType GetEnvironment()
        {

            string value = ConfigurationManager.AppSettings["Environment"];
            if (value.ToLower() == "test")
            {
                return EnvironmentType.Test;
            }
            else if (value.ToLower() == "prod")
            {
                return EnvironmentType.Prod;
            }
            else
            {
                throw new Exception("Invalid environment type!");
            }
        }

        //private Configuration GetConfiguration()
        //{
        //    Configuration configuration;
        //    try
        //    {
        //        string path = string.Concat(Path.GetFullPath("..\\..\\..\\"), "common.config");
        //        configuration = ConfigurationManager.OpenMappedMachineConfiguration(new ConfigurationFileMap(path));
        //    }
        //    catch (Exception)
        //    {
        //        string path = "common.config";
        //        configuration = ConfigurationManager.OpenMappedMachineConfiguration(new ConfigurationFileMap(path));
        //    }

        //    return configuration;
        //}

        //private string GetValue(string key)
        //{
        //    Configuration configuration = GetConfiguration();
        //    string value = configuration.AppSettings.Settings[key].Value;
        //    return value;
        //}
    }
}
