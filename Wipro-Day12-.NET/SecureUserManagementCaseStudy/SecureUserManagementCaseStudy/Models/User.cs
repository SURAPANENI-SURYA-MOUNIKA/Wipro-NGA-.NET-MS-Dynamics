using SecureUserManagementCaseStudy.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureUserManagementCaseStudy.Models
{
      
        public class User
        {
            public string Username { get; set; }
            public string HashedPassword { get; set; }

            public User(string username, string hashedPassword)
            {
                Username = username;
                HashedPassword = hashedPassword;
            }
        }
    }
