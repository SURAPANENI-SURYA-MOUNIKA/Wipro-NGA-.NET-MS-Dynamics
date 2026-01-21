using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using System.IO;
namespace SecureUserManagementCaseStudy.Logging
{
    public static class LoggerService
    {
        public static class Logger
        {
            private static readonly string logFile = "application.log";

            public static void Log(string message)
            {
                File.AppendAllText(logFile,
                    $"{DateTime.Now} : {message}{Environment.NewLine}");
            }

            public static void LogError(Exception ex)
            {
                File.AppendAllText(logFile,
                    $"{DateTime.Now} ERROR: {ex.Message}{Environment.NewLine}");
            }
        }
    }
}