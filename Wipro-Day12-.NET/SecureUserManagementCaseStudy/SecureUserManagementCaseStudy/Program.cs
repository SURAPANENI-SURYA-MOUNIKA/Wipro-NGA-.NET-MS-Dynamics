using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecureUserManagementCaseStudy.Services;

namespace SecureUserManagementCaseStudy
{
    class Program
    {
            static void Main()
            {
                AuthService service = new AuthService();

                service.Register("admin", "password123");

                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (service.Authenticate(username, password))
                    Console.WriteLine("Login Successful");
                else
                    Console.WriteLine("Invalid Credentials");

                Console.ReadLine();
            }
        }
    }
