using System;
using System.Collections.Generic;

namespace Flexi.Model.Poco
{


    public class ServiceResponse<T>
    {
        public T ResponseObject { get; set; }
        public List<T> ResponseList { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public Exception Exception
        {
            set
            {
                ResponseCode = 0;
                ResponseMessage = string.Concat(
                    "Error Message :", value.Message, Environment.NewLine
                   , "Inner Exception :", value.InnerException, Environment.NewLine
                   , "Stack Trace :", value.StackTrace);
            }
           
        }
    }
}
