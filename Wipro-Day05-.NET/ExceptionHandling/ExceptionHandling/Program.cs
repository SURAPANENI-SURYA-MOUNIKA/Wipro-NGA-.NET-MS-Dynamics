using System;                                   // We need this to use Console, Exception classes etc.

namespace ExceptionHandling                     // All our code belongs to this namespace (group/folder)
{
    class Program                               // Main class where our program starts
    {
        static void Main(string[] args)         // This is the starting point of our program
        {
            // Just welcoming messages to show what the program is about
            Console.WriteLine("Hello World!");
            Console.WriteLine("Here is an example of Exception Handling in C#.NET");
            Console.WriteLine();                // Empty line for better looking output

         
            Console.WriteLine("=== Division Example ===\n");

            while (true)                        // Keep asking until user enters correct number
            {
                try                             // "try" block - here we write code that might cause error
                {
                    Console.Write("Enter a number to divide 100 by: ");
                    int number = Convert.ToInt32(Console.ReadLine());   // Read what user types and convert to number
                    int result = 100 / number;                          // This line can cause DivideByZero error!

                    Console.WriteLine($"Result = {result}");            // Show the answer if everything is OK
                    Console.WriteLine();                                // Empty line
                    break;                      // Important! Exit the while loop when success
                }
                catch (DivideByZeroException)   // Catches only when someone tries to divide by 0
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                    Console.WriteLine("Please enter a non-zero number.\n");
                }
                catch (FormatException)         // Catches when user types letters instead of numbers
                {
                    Console.WriteLine("Error: Please enter a valid integer number!\n");
                }
                // You can add more catch blocks for other types of errors if needed
            }

           
            Console.WriteLine("=== Bank Account Daily Limit Example ===\n");

            BankAccount account = new BankAccount();    // Create a new bank account object

            try
            {
                Console.WriteLine("Trying some transactions...");

                account.MakeTransaction(400);   // First transaction - should work
                account.MakeTransaction(500);   // Second transaction - should work
                account.MakeTransaction(300);   // Third transaction - will cause our custom error!
            }
            catch (DailyLimitExceededException ex)      // Our own special error type
            {
                Console.WriteLine("\nERROR: " + ex.Message);    // Show the error message we wrote
            }

            // Final messages when program ends
            Console.WriteLine("\nProgram finished.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();                  // Wait for user to press any key before closing window
        }
    }
}











































/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class DailyLimitExceededException : Exception
    {
        public DailyLimitExceededException(string message):base(message)
        //calling base class constructor inside derived class constructor
        {



        }
    }
    //creating  a account class that act as a business logic class for implementing user define exception

    // Custom user-defined exception
    
    // Business logic class
    class BankAccount //business logic class
    {
        private decimal dailyLimit = 1000; //daily limit for transactions
        private decimal totalTransactionsToday = 0; //to keep track of total transactions made today
        public void MakeTransaction(decimal amount)
        {
            if (totalTransactionsToday + amount > dailyLimit)
            {
                //throwing user define exception when daily limit is exceeded.
                throw new DailyLimitExceededException("Daily transaction limit exceeded.");
            }
            totalTransactionsToday += amount;
            Console.WriteLine($"Transaction of {amount} completed successfully.");
        }
    }

}
*/





















/*using ExceptionHandling;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Here is an example of Exception Handling in C#.NET");
        Console.WriteLine();

        while (true)
        {
            try
            {
                Console.Write("Enter a number to divide 100 by: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int result = 100 / number;

                Console.WriteLine($"Result = {result}");
                Console.WriteLine();
                break; // successful → exit loop
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                Console.WriteLine("Please enter a non-zero number.");
                Console.WriteLine();
            }
            catch(DailyLimitExceededException ex)
            {

            }
          //  catch (FormatException)
           // {
            //    Console.WriteLine("Error: Please enter a valid number!");
            //    Console.WriteLine();
            //}
        }

        //Console.WriteLine("Execution completed. Thank you!");
        //Console.WriteLine("Press any key to close...");
        //Console.ReadKey();
    }
}*/