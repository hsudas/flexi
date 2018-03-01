using System;

namespace Flexi.Model.Entity
{
    public class ErrorLog : MongoRepository.Entity
    {
        public string Project { get; set; }
        public string MethodName { get; set; }
        public string ErrorText { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
