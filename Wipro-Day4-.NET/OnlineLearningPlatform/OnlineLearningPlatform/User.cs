using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform
{
 


        // This is an instance-based class
        public class User
        {
            // Instance property
            public string Username { get; set; }

            // Constructor
            public User(string username)
            {
                Username = username;

                // Increase global user count
                PlatformConfig.IncrementUser();
            }
        }
    }

