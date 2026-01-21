// See https://aka.ms/new-console-template for more information
using System;
using OnlineLearningPlatform;

namespace OnlineLearningPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accessing static properties (NO object creation)
            Console.WriteLine("Platform Name: " + PlatformConfig.PlatformName);
            Console.WriteLine("Max Login Attempts: " + PlatformConfig.MaxLoginAttempts);
            Console.WriteLine("Total Users: " + PlatformConfig.TotalUsers);

            Console.WriteLine("\nCreating users...\n");

            // Creating user objects
            User user1 = new User("Mounika");
            User user2 = new User("Rahul");

            // Display user details
            Console.WriteLine("User 1: " + user1.Username);
            Console.WriteLine("User 2: " + user2.Username);

            // Updated static value
            Console.WriteLine("\nTotal Users After Registration: " + PlatformConfig.TotalUsers);

            Console.ReadLine();
        }
    }
}

