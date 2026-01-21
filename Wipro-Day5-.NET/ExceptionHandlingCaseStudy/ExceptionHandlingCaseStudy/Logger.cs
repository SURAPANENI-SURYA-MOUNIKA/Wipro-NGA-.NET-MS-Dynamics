using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingCaseStudy
{
    // Simple static logger class
    public static class Logger
    {
        // This must be a method - you can't write code directly in class body
        public static void Log(Exception ex)
        {
            // Get current date and time
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Get name of exception type (ValidationException, BusinessRuleException, etc.)
            string exceptionType = ex.GetType().Name;

            // Create nice log message
            string logMessage = $"[{timestamp}] {exceptionType}: {ex.Message}";

        
            Console.WriteLine(logMessage);
            
        }
    }
}
