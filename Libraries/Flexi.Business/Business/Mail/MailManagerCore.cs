using Amazon;
using Amazon.Runtime;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Flexi.Shared.Helper;
using Flexi.Model.Poco;
using Flexi.Business.Business.DB;
using Flexi.Business.Business.DB.Ext;
using Flexi.Business.Model;
using Flexi.Business.Model.Security;
using Dapper;
using MimeKit;
using Npgsql;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace Flexi.Business.Business.Mail.Helper
{
    public class MailManagerCore
    {
        NpgsqlConnection con;
        /// <summary>
        /// If it will be taken mail records via db connection, you mus enter proper connection string.
        /// </summary>
        public string ConnectionString { get; set; }
        public string WSUserName { get; set; }
        public string WSPassword { get; set; }
        public string WSUrl { get; set; }

        public string AccessKey { get; set; }
        public MailManagerCore()
        { }
        /// <summary>
        /// You must assing db connection string into connectionString parameter.
        /// System will read records from dbo.MailSend table.
        /// </summary>
        /// <param name="connectionString"></param>
        public MailManagerCore(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        /// <summary>
        /// If you send mail via web api and you don't have any token in your system. You must enter your username, password and api url.
        /// </summary>
        /// <param name="wsUserName">Your royal system username</param>
        /// <param name="wsPassword">Your royal system password</param>
        /// <param name="wsUrl">web api  base url. Default value : http://service.royalqg.com/ </param>
        public MailManagerCore(string wsUserName, string wsPassword, string wsUrl = "http://service.royalqg.com/")
        {
            this.WSUserName = wsUserName;
            this.WSPassword = wsPassword;
            this.WSUrl = wsUrl;
            Token tk = Token.GetToken(wsUserName, wsPassword);
            if (tk != null)
            {
                this.AccessKey = tk.AccessKey;
            }

        }
        /// <summary>
        /// If you have a token in your application. (Ex: Royal Studio, ) You can use its access key to login web Api.
        /// </summary>
        /// <param name="accessKey">Access Key in your application that logged in</param>
        /// <param name="wsUrl">web api url</param>
        public MailManagerCore(string accessKey, string wsUrl = "http://service.royalqg.com/")
        {
            this.AccessKey = accessKey;
            this.WSUrl = wsUrl;

        }

        public List<MailSend> GetMailsFromDB()
        {
            if (this.ConnectionString == "")
            {
                throw new Exception("Please enter connection string to db connection!");
            }
            List<MailSend> lstMs = new List<MailSend>();

            using (con = new NpgsqlConnection(this.ConnectionString))
            {
                con.Open();
                DateTime dt = DateTime.Now;
                lstMs = con.Query<MailSend>("Select * From MailSend Where SendDate <= @CurrentDate Limit 10; ", new { CurrentDate = dt }).ToList<MailSend>();
                // con.Execute("Delete From MailSend Where SendDate <= @CurrentDate;", new { CurrentDate = dt });
            }
            return lstMs;
        }
        public MailProfile GetMailProfile(string mail)
        {
            using (con = new NpgsqlConnection(this.ConnectionString))
            {
                con.Open();
                List<MailProfile> prfList = con.Query<MailProfile>("Select * From MailProfile Where Sender = @Sender", new { Sender = mail }).ToList<MailProfile>();
                if (prfList.Count > 0)
                {
                    return prfList[0];
                }
            }
            return null;
        }

        public void StartEngine()
        {

            // take mail records to send
            List<MailSend> mailList = GetMailsFromDB();
            if (mailList.Count > 0)
            {
                foreach (MailSend mail in mailList)
                {
                    MailSendArchive msa = new MailSendArchive();
                    msa.Body = mail.Body;
                    msa.FilePath = mail.FilePath;
                    msa.Description = mail.Description;
                    msa.InsertDate = DateTime.Now;
                    msa.MailType = mail.MailType;
                    msa.Module = mail.Module;
                    msa.Sender = mail.Sender;
                    msa.Subject = mail.Subject;
                    msa.ToAddress = mail.ToAddress;
                    msa.CC = mail.CC;
                    MailProfile mprof = GetMailProfile(mail.Sender);
                    if (mprof == null)
                    {
                        msa.ErrDescription = "Mail Profile doesn't exist!";
                        msa.MailStatus = 2;
                        msa.SendDate = null;
                    }
                    else
                    {
                        try
                        {
                            if (mprof.SendMethod == 1)
                            {

                                //amazon

                                List<string> adr = new List<string>();
                                List<string> ccadr = new List<string>();
                                if (mail.ToAddress.Contains(';'))
                                {
                                    adr = mail.ToAddress.Split(';').ToList<string>();

                                }
                                else
                                {
                                    adr.Add(mail.ToAddress);
                                }
                                if (mail.CC != null)
                                {
                                    if (mail.CC != "")
                                    {
                                        if (mail.CC.Contains(';'))
                                        {
                                            ccadr = mail.CC.Split(';').ToList<string>();

                                        }
                                        else
                                        {
                                            ccadr.Add(mail.CC);
                                        }
                                    }

                                }

                                SendAmazonEmails(mail.Body, mail.Subject, adr, ccadr, mail.FilePath, mprof.DisplayName, mprof.Sender);
                            }
                            else
                            {
                                //send method smtp
                                MailMessage mm = new MailMessage();
                                SmtpClient smtpServer = new SmtpClient(mprof.Server);
                                mm.From = new MailAddress(mprof.Sender, mprof.DisplayName);
                                if (mail.ToAddress.Contains(';'))
                                {
                                    List<string> adr = mail.ToAddress.Split(';').ToList<string>();
                                    foreach (string item in adr)
                                    {
                                        mm.To.Add(item);
                                    }
                                }
                                else
                                {
                                    mm.To.Add(mail.ToAddress);
                                }

                                if (mail.CC != null)
                                {
                                    if (mail.CC != "")
                                    {
                                        if (mail.CC.Contains(';'))
                                        {
                                            List<string> adr = mail.CC.Split(';').ToList<string>();
                                            foreach (string item in adr)
                                            {
                                                mm.CC.Add(item);
                                            }
                                        }
                                        else
                                        {
                                            mm.CC.Add(mail.CC);
                                        }
                                    }


                                }

                                System.Net.Mail.Attachment attachment;
                                if (mail.FilePath != "" && mail.FilePath != null)
                                {
                                    attachment = new System.Net.Mail.Attachment(mail.FilePath);
                                    mm.Attachments.Add(attachment);
                                }
                                if (mprof.Port == null)
                                {
                                    smtpServer.Port = 25;
                                }
                                else
                                {
                                    smtpServer.Port = Convert.ToInt32(mprof.Port);

                                }
                                smtpServer.Credentials = new System.Net.NetworkCredential(mprof.Sender, mprof.Password);
                                smtpServer.Send(mm);

                            }
                        }
                        catch (Exception ex)
                        {
                            msa.MailStatus = 2;
                            msa.SendDate = null;
                            msa.ErrDescription = ex.Message;
                            Console.WriteLine(ex.Message + ex.StackTrace);
                        }

                    }

                    SendArchive(msa, mail.Id);
                }
            }

        }
        private MailAddressCollection ParseMailAddresses(string adr)
        {
            MailAddressCollection col = new MailAddressCollection();
            if (adr.Contains(';'))
            {
                List<string> lst = adr.Split(';').ToList<string>();
                foreach (string item in lst)
                {
                    col.Add(item);
                }
            }
            else
            {
                col.Add(adr);

            }

            return col;
        }
        public void SendArchive(MailSendArchive mail, long id)
        {
            using (con = new NpgsqlConnection(this.ConnectionString))
            {
                con.Open();
                con.Execute("DELETE FROM mailsend WHERE id = " + id);
                con.InsertPg<MailSendArchive>(mail);
            }
        }

        public List<MailSend> GetMailsFromWS()
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.WSUrl);
            request.Headers.Add("Authorization", this.AccessKey);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            //StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
            ServiceResponse<MailSend> sr = new ServiceResponse<MailSend>();
            sr = JsonHelper.Instance.DeserializeFromStream<ServiceResponse<MailSend>>(responseStream);
            if (sr.ResponseCode == 1)
            {
                return sr.ResponseList;
            }
            else if (sr.ResponseCode == 0)
            {
                throw new Exception(sr.ResponseMessage);
            }
            return null;
        }
        public void InsertMailDB(MailSend ms)
        {
            QueryManager qm = new QueryManager(this.ConnectionString);
            qm.InsertObject<MailSend>(ms);

        }
        public void InsertMailWS(MailSend ms)
        {
            RestClient client = new RestClient(this.WSUrl);
            var request = new RestRequest("Api/Mail/InsertMail", Method.POST);
            request.AddHeader("Authorization", this.AccessKey);
            request.AddJsonBody(ms);
            IRestResponse res = client.Execute(request);
            ServiceResponse<MailSend> sr = SimpleJson.DeserializeObject<ServiceResponse<MailSend>>(res.Content);
            if (sr.ResponseCode == 1)
            {
                throw new Exception(sr.ResponseMessage);
            }
            if (res.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(res.StatusDescription);
            }
        }

        #region Amazon Send Mail With Attachment
        private static BodyBuilder GetMessageBody(string body, string attachmentPath)
        {
            var bd = new BodyBuilder()
            {
                HtmlBody = @body

            };
            if (attachmentPath != "" && attachmentPath != null)
            {
                bd.Attachments.Add(@attachmentPath);

            }
            return bd;
        }

        private static MimeMessage GetMessage(string body, string subject, List<string> toAddList, List<string> ccAddList, string attachmentPath, string displayName, string from)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(displayName, from));
            foreach (string toitem in toAddList)
            {
                message.To.Add(new MailboxAddress(string.Empty, toitem));

            }
            if (ccAddList != null)
            {
                if (ccAddList.Count > 0)
                {
                    foreach (string ccitem in ccAddList)
                    {
                        message.Cc.Add(new MailboxAddress(string.Empty, ccitem));

                    }
                }
            }

            message.Subject = subject;
            message.Body = GetMessageBody(body, attachmentPath).ToMessageBody();
            return message;
        }

        private static MemoryStream GetMessageStream(string body, string subject, List<string> toAddList, List<string> ccAddList, string attachmentPath, string displayName, string from)
        {
            var stream = new MemoryStream();
            GetMessage(body, subject, toAddList, ccAddList, attachmentPath, displayName, from).WriteTo(stream);
            return stream;
        }

        private void SendAmazonEmails(string body, string subject, List<string> toAddList, List<string> ccAddList, string attachmentPath, string displayName, string from)
        {
            var credentals = new BasicAWSCredentials("AKIAJ3Y6RNHOGDYBN3PA", "YsnHRlKn+RxF4NWwuToiq3SYKxYEoc5w5vR/ebMx");

            using (var client = new AmazonSimpleEmailServiceClient(credentals, RegionEndpoint.USWest2))
            {
                RawMessage rmsg = new RawMessage(GetMessageStream(body, subject, toAddList, ccAddList, attachmentPath, displayName, from));
                var sendRequest = new SendRawEmailRequest { RawMessage = rmsg };
                var response = client.SendRawEmail(sendRequest);
                Console.WriteLine("AMAZON email was sent successfully.");


            }
        }
        #endregion

    }


}
