using Flexi.Model.Entity;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using MongoRepository;
using System;
using System.Diagnostics;

namespace Flexi.Shared.Log
{
    public class Logger
    {
        private static string appName = string.Empty;
        private static ILog log;
        private static bool isJobScheduler = false;
        private static Object theLock = new Object();
        private static MongoRepository<ErrorLog> errorLogRepository = new MongoRepository<ErrorLog>();

        public static void Setup(string logRootPath)
        {
            var hierarchy = (Hierarchy)LogManager.GetRepository();
            hierarchy.Threshold = Level.Debug;
            var loggerA = hierarchy.LoggerFactory.CreateLogger(hierarchy, appName);
            loggerA.Hierarchy = hierarchy;
            loggerA.AddAppender(CreateFileAppender(logRootPath));
            loggerA.Repository.Configured = true;
            loggerA.Level = Level.Debug;
            log = new LogImpl(loggerA);
        }

        private static IAppender CreateFileAppender(string filePath)
        {
            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date %level %logger: %message%newline"; //"%date [%-4thread] %-5level %logger{1} - %message%newline";// "%date [%thread] %-5level %logger : %message%newline";  //"%date %level %logger: %message%newline";
            patternLayout.ActivateOptions();
            string applicationName = string.Empty;
            RollingFileAppender appender = new RollingFileAppender();
            if (appName == string.Empty)
            {
                applicationName = Process.GetCurrentProcess().ProcessName.Replace(".vshost", string.Empty).Replace(".", "_");
            }
            else
            {
                applicationName = appName;
            }
            //appender.Name = name;
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString().PadLeft(2, '0');
            string day = DateTime.Now.Day.ToString().PadLeft(2, '0');
            appender.File = string.Concat(filePath, "\\", applicationName, "\\", year, "\\", month, "\\", year, month, day, applicationName, "_log.txt");
            appender.AppendToFile = true;
            appender.MaxSizeRollBackups = 15;
            appender.RollingStyle = RollingFileAppender.RollingMode.Date;
            appender.MaximumFileSize = "10MB";
            appender.Layout = patternLayout;
            appender.LockingModel = new FileAppender.MinimalLock();
            appender.StaticLogFileName = true;
            appender.ActivateOptions();
            return appender;
        }

        public static void Setup()
        {
            Setup("D:\\AppLog");
        }

        public static ILog Setup(string logRootPath, string applicationName)
        {
            appName = applicationName;
            Setup(logRootPath);
            return log;
        }

        public static ILog Setup(string logRootPath, string applicationName, bool isJobScheduler)
        {
            Logger.isJobScheduler = isJobScheduler;
            appName = applicationName;
            Setup(logRootPath);
            return log;
        }

        public static void Error(string msg)
        {
            CheckLogInstance();
            StackFrame frame = new StackFrame(1);
            var method = frame.GetMethod();
            var type = method.DeclaringType;
            var name = method.Name;
            Console.WriteLine(string.Concat("[ERROR]", "[", DateTime.Now, "][", type, ".", name, "]: ", msg));
            log.Error(msg);
            CreateErrorLog(new ErrorLog() { Project = type.FullName, MethodName = name, ErrorText = msg, ExceptionMessage = string.Empty, StackTrace = string.Empty });
        }

        public static void Error(Exception exc)
        {
            CheckLogInstance();
            StackFrame frame = new StackFrame(1);
            var method = frame.GetMethod();
            var type = method.DeclaringType;
            var name = method.Name;
            Console.WriteLine(string.Concat("[ERROR]", "[", DateTime.Now, "][", type, ".", name, "]: ", exc.Message, exc.StackTrace));
            log.Error(exc);
        }

        public static void Error(string msg, Exception exc)
        {
            CheckLogInstance();
            StackFrame frame = new StackFrame(1);
            var method = frame.GetMethod();
            var type = method.DeclaringType;
            var name = method.Name;
            Console.WriteLine(string.Concat("[ERROR]", "[", DateTime.Now, "][", type, ".", name, "]: ", msg, "[ERROR]", "[", DateTime.Now, "][", type, ".", name, "]: ", exc.Message, exc.StackTrace));
            log.Error(msg, exc);
            CreateErrorLog(new ErrorLog() { Project = type.FullName, MethodName = name, ErrorText = msg, ExceptionMessage = exc.Message, StackTrace = exc.StackTrace });
        }

        public static void Info(string msg)
        {
            lock (theLock)
            {
                CheckLogInstance();
                StackFrame frame = new StackFrame(1);
                var method = frame.GetMethod();
                var type = method.DeclaringType;
                var name = method.Name;
                Console.WriteLine(string.Concat("[INFO]", "[", DateTime.Now, "][", type, ".", name, "]: ", msg));
                log.Info(msg);
            }
        }

        private static void CheckLogInstance()
        {
            if (isJobScheduler)
            {
                GetJobName();
            }
            else if (log == null)
            {
                Setup();
            }
        }

        private static void GetJobName()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame[] stackFrames = stackTrace.GetFrames();

            foreach (StackFrame stackFrame in stackFrames)
            {
                if (stackFrame.GetMethod().Name.Equals("Execute"))
                {
                    string jobName = stackFrame.GetMethod().DeclaringType.Name;
                    Logger.Setup(@"D:\AppLog", jobName, true);
                    break;
                }
            }
        }

        private static void CreateErrorLog(ErrorLog errorLog)
        {
            try
            {
                errorLog.CreateDate = DateTime.Now;
                errorLogRepository.Add(errorLog);
            }
            catch (Exception exc)
            {
                log.Error("CreateErrorLog error!", exc);
            }
        }
    }
}
