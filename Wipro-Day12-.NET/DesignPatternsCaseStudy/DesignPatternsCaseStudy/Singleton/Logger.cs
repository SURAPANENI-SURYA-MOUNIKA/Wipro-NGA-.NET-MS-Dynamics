using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCaseStudy.Singleton
{
    
    public class Logger
    {
        // Holds the single instance of Logger
        private static Logger _instance;

        // Lock object used for thread safety
        private static readonly object _lock = new object();

        // Private constructor prevents object creation from outside
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                //  only one thread can execute this code at a time
                lock (_lock)
                {
                    // Create instance only if it does not exist
                    if (_instance == null)
                        _instance = new Logger();
                }

                // Return the same instance every time
                return _instance;
            }
        }

        // Method to write log message
        public void Log(string message)
        {
            
            Console.WriteLine("Log Message: " + message);
        }
    }
}

