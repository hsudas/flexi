using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model
{
    /// <summary>
    /// It is passed as parameter to SendMail Method.
    /// </summary>
    public class MailInput
    {
        /// <summary>
        /// It contains mail addresses to send mail.
        /// If you want to use multiple mail adress. You must put ';' after each address. 
        /// For example : hsudas@gmail.com;eecetin@gmail.com;rte@turkey.gov.tr;parallel@transoceanic.com
        /// </summary>
        public string To { get; set; }
        /// <summary>
        /// It contains cc mail addresses. Its structure is the same of 'To'.
        /// </summary>
        public string CC { get; set; }
        /// <summary>
        /// Sender mail address. This address must be defined in MailProfile table with required mail settings. 
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// You can write html or raw text messages to this field. There is no character limit.
        /// </summary>
        public string Body { get; set; }

        public string Subject { get; set; }

        public string AttachPath { get; set; }
        public DateTime? SendDate { get; set; }

        public ConnectionMethod ConnectionMethod { get; set; }
        public MailType MailType { get; set; }

        public int? MailTemplateId { get; set; }

    }
    public enum SendMethod
    {
        SMTP = 0,
        AMAZON = 1
    }

    public enum ConnectionMethod
    {
        DataBase = 0,
        WebApi = 1
    }

    public enum MailType
    {
        Information = 0,
        Advertisement = 1,
        Error = 2
    }
}
