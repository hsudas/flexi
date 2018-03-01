using System;
using System.Diagnostics;
using System.Linq;

namespace Flexi.Shared.Helper
{
    public class ExceptionHelper
    {
        private static readonly Lazy<ExceptionHelper> lazy = new Lazy<ExceptionHelper>(() => new ExceptionHelper());
        public static ExceptionHelper Instance { get { return lazy.Value; } }
        private ExceptionHelper()
        {
        }

        public string GetExceptionDetail(Exception exc)
        {
            string errorMessage = string.Empty;
            var stackTrace = new StackTrace(exc, true); // create the stack trace
            var query = stackTrace.GetFrames()         // get the frames
                          .Select(frame => new
                          {                   // get the info
                              FileName = frame.GetFileName(),
                              LineNumber = frame.GetFileLineNumber(),
                              ColumnNumber = frame.GetFileColumnNumber(),
                              Method = frame.GetMethod(),
                              Class = frame.GetMethod().DeclaringType,
                          });
            foreach (var i in query)
            {
                errorMessage += string.Concat(i.FileName, " : ", i.Class, " : ", i.Method, " : ", i.LineNumber, " : ", i.ColumnNumber, System.Environment.NewLine);
            }
            return errorMessage;
        }
    }
}
