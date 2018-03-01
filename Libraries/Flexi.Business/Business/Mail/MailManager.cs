using Flexi.Model.Entity;
using Flexi.Business.Business.DB;
using Flexi.Business.Model;
using Flexi.Business.Model.DB;
using Flexi.Business.Model.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Flexi.Business.Business.Mail
{
    public class MailManager
    {
        QueryManager qm;
        Flexi.Business.Business.Mail.Helper.MailManagerCore mc;
        /// <summary>
        /// If it will be taken mail records via db connection, you mus enter proper connection string.
        /// </summary>
        public string ConnectionString { get; set; }
        public string WSUserName { get; set; }
        public string WSPassword { get; set; }
        public string WSUrl { get; set; }

        public string AccessKey { get; set; }
        public MailManager()
        {
            mc = new Helper.MailManagerCore();
        }
        /// <summary>
        /// You must assing db connection string into connectionString parameter.
        /// System will read records from dbo.MailSend table.
        /// </summary>
        /// <param name="connectionString"></param>
        public MailManager(string connectionString)
        {
            this.ConnectionString = connectionString;
            mc = new Helper.MailManagerCore(this.ConnectionString);
            qm = new QueryManager(this.ConnectionString);
        }

        /// <summary>
        /// If you send mail via web api and you don't have any token in your system. You must enter your username, password and api url.
        /// </summary>
        /// <param name="wsUserName">Your royal system username</param>
        /// <param name="wsPassword">Your royal system password</param>
        /// <param name="wsUrl">web api  base url. Default value : http://service.royalqg.com/ </param>
        public MailManager(string wsUserName, string wsPassword, string wsUrl = "http://service.royalqg.com/")
        {
            this.WSUserName = wsUserName;
            this.WSPassword = wsPassword;
            this.WSUrl = wsUrl;
            Token tk = Token.GetToken(wsUserName, wsPassword);
            if (tk != null)
            {
                this.AccessKey = tk.AccessKey;
            }
            mc = new Helper.MailManagerCore(wsUserName, wsPassword, wsUrl);
            this.qm = new QueryManager(this.AccessKey, true);
        }
        /// <summary>
        /// If you have a token in your application. (Ex: Royal Studio, ) You can use its access key to login web Api.
        /// </summary>
        /// <param name="accessKey">Access Key in your application that logged in</param>
        /// <param name="wsUrl">web api url</param>
        public MailManager(string accessKey, string wsUrl = "http://service.royalqg.com/")
        {
            this.AccessKey = accessKey;
            this.WSUrl = wsUrl;
            mc = new Helper.MailManagerCore(accessKey, wsUrl);
            this.qm = new QueryManager(this.AccessKey, true);
        }


        public void SendMail(MailInput mail)
        {
            //validation
            if (mail.To == "")
            {
                throw new Exception("Please enter an E-Mail address to 'To' parameter!");
            }
            try
            {
                if (mail.To.Contains(';') == false)
                {

                    var addr = new System.Net.Mail.MailAddress(mail.To);

                }
                else
                {
                    foreach (string item in mail.To.Split(';'))
                    {
                        if (item != "")
                        {
                            var addr = new System.Net.Mail.MailAddress(item);
                        }

                    }
                }

                if (mail.CC != null)
                {
                    if (mail.CC.Contains(';') == false)
                    {

                        var addr = new System.Net.Mail.MailAddress(mail.CC);

                    }
                    else
                    {
                        foreach (string item in mail.CC.Split(';'))
                        {
                            if (item != "")
                            {
                                var addr = new System.Net.Mail.MailAddress(item);

                            }

                        }
                    }
                }

            }
            catch (Exception)
            {

                throw new Exception("One of the receipent mail addresses are not valid.");
            }

            if (mail.ConnectionMethod == null)
            {
                throw new Exception("Please select a connection method.");
            }


            if (mail.MailType == null)
            {
                throw new Exception("Please select a mail type.");

            }
            //prepare object instance
            MailSend ms = new MailSend();
            if (mail.MailTemplateId !=null)
            {
                if (string.IsNullOrEmpty(this.ConnectionString))
                {
                    throw new Exception("Template stucture is only available with db connection.");
                }
                List<IDataParameter> paramlist = new List<IDataParameter>();
                paramlist.Add(new CustomParameter("id", mail.MailTemplateId));
                List<MailTemplate>  mtlist = qm.GetQueryResult<MailTemplate>("GetMailTemplate", paramlist);
                if (mtlist.Count == 0)
                {
                    throw new Exception("Mail Template has not been found on db!");
                }
                else
                {
                    MailTemplate mt = mtlist[0];
                    string[] variables = null;

                    string body = File.ReadAllText(mt.TemplateText);
                    if (mt.Variables != "" && mt.Variables.Contains(","))
                    {
                        variables = mt.Variables.Split(',');
                       
                    }
                    if (mt.QueryType == "select")
                    {
                        DataTable dt  = qm.GetQueryResultDataTableDirect(mt.Query,null);
                        if (dt.Rows.Count > 0)
                        {
                            string itr = "";
                            if (body.Contains("##for") && body.Contains("##endfor"))
                            {
                                Regex rgx = new Regex("##for(\n|.)*##endfor");
                                MatchCollection mtcol = rgx.Matches(body);
                                foreach (Match mtc in mtcol)
                                {
                                    if (mtc.Success)
                                    {

                                        itr = mtc.Value;
                                       
                                        string newstr = itr;
                                        string lastStr = "";
                                        foreach (DataRow dr in dt.Rows)
                                        {
                                            foreach (string vr in variables)
                                            {
                                                newstr = newstr.Replace("#" + vr, dr[vr].ToString());
                                            }
                                            lastStr = lastStr + newstr;
                                            newstr = itr;
                                        }
                                        body = body.Replace(itr, lastStr);
                                    }
                                }
                                
                            }

                            DataRow drow = dt.Rows[0];
                            foreach (string vr in variables)
                            {
                                body = body.Replace("#" + vr, drow[vr].ToString());
                            }
                            body = body.Replace("##for","").Replace("##endfor","");
                        }
                        
                        
                    }
                    else if (mt.QueryType == "execute")
                    {
                        int result = qm.ExecuteQueryText(mt.Query);
                    }
                    else
                    {
                        throw new Exception("Please choose querytype between select and execute options.");
                    }

                    
                  
                    ms.Body = body;
                }
            }
            else
            {
                ms.Body = mail.Body;
            }

            ms.FilePath = mail.AttachPath;
            ms.MailType = Convert.ToInt16(mail.MailType);
            ms.MailStatus = 1;
            ms.Module = "";
            ms.Sender = mail.From;
            ms.SendDate = mail.SendDate;
            ms.Subject = mail.Subject;
            ms.ToAddress = mail.To;
            ms.CC = mail.CC;
            ms.InsertDate = DateTime.Now;
            if (ms.SendDate == null)
            {
                ms.SendDate = DateTime.Now;
            }

            //insert to sendmail

            if (mail.ConnectionMethod == ConnectionMethod.DataBase)
            {
                if (ConnectionString == "")
                {
                    throw new Exception("Altough your connection method is Database. Your connection string is empty!. Please enter valid database connection string into constructor method.");
                }
                mc.InsertMailDB(ms);

            }
            else if (mail.ConnectionMethod == ConnectionMethod.WebApi)
            {
                if (AccessKey == "")
                {
                    throw new Exception("Altough your connection method is Web Api. Your AccessKey is empty!. Please enter valid Access Key  into constructor method.");

                }
                mc.InsertMailWS(ms);
            }




        }
    }
}
