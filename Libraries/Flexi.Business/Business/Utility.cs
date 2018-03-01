using Flexi.Shared.Helper;
using Flexi.Model;
using System;
using System.Configuration;
using System.Net.Mail;

namespace Flexi.Business.Business
{
    public class Utility
    {
        public static void UpdateConfigSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }
        public static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString();

        }

        /// <summary>
        /// Application config'deki credential ayarlarına göre mail gönderir.
        /// </summary>
        /// <param name="toAddress">mail gidecek adresler. "orn@microsoft.com;example@oracle.com"  formatında gönderim yapılmalıdır.</param>
        /// <param name="subject"></param>
        /// <param name="cc">cc ye konacak kişiler. orn : "falanfilan@orn.com;etc@asshole.com"</param>
        /// <param name="bodyText">body'e yazılacak metin</param>
        /// <param name="attachmentPath">attach dosyası eklenecekse serverdaki pathini yazmamız yeterli.</param>
        /// <param name="applicationName">mail gönderilen sistemin adı</param>
        /// <returns></returns>
        public static bool SendMail(string toAddress, string subject, string cc, string bodyText, string attachmentPath, string applicationName)
        {
            MailMessage mail = new MailMessage();
            string smtpServerName = GetConfigValue("mailserver");
            string mailFrom = GetConfigValue("mailfrom");
            mailFrom = applicationName + " <" + mailFrom + ">";
            string userName = GetConfigValue("mailusername");
            string password = GetConfigValue("mailpassword");
            string port = GetConfigValue("mailport");
            SmtpClient SmtpServer = new SmtpClient(smtpServerName);
            mail.From = new MailAddress(mailFrom);

            string[] toArr = toAddress.Split(';');
            foreach (string item in toArr)
            {
                mail.To.Add(item);

            }
            mail.Subject = subject;
            mail.Body = bodyText;
            if (cc != "")
            {
                string[] ccArr = cc.Split(';');
                foreach (string item in ccArr)
                {
                    mail.CC.Add(item);
                }
            }


            System.Net.Mail.Attachment attachment;
            if (attachmentPath != "")
            {
                attachment = new System.Net.Mail.Attachment(attachmentPath);
                mail.Attachments.Add(attachment);
            }
            SmtpServer.Port = Convert.ToInt32(port);
            SmtpServer.Credentials = new System.Net.NetworkCredential(userName, password);
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            return true;
        }
        public static bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool IsValidEmailAddress2(string email, bool xx)
        {
            try
            {
                MailAddress ma = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void SendMailException(string title, Exception ex = null)
        {
            //string conStr = ConfigHelper.Instance.GetDBContext();
            //MailManager mailmanager = new MailManager(conStr);
            //MailInput mailInput = new MailInput();
            //if (ex != null)
            //{
            //    mailInput.Body = ex.Message + ex.StackTrace;
            //}
            //else
            //{
            //    mailInput.Body = title;
            //}
            //// mi.CC = "eecetin@gmail.com";
            //mailInput.ConnectionMethod = ConnectionMethod.DataBase;
            //mailInput.From = "info@royalqg.com";
            //mailInput.MailType = MailType.Error;
            //mailInput.SendDate = DateTime.Now;
            //mailInput.Subject = title;
            //mailInput.To = "it@royalqg.com";
            //mailmanager.SendMail(mailInput);
        }


    }
}
