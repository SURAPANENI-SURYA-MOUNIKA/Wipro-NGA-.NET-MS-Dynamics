using System;                             

namespace ExceptionHandling                 
{
    //  creating our OWN error type (custom exception)
    public class DailyLimitExceededException : Exception
    {
        // Constructor - this runs when someone creates our error
        public DailyLimitExceededException(string message)
            : base(message)                 // Send message to normal Exception class
        {
            // Nothing extra needed here
        }
    }

    // This is our main class (like a real bank account)
    public class BankAccount
    {
        private decimal dailyLimit = 1000m;             // Maximum allowed per day (m = decimal number)
        private decimal totalTransactionsToday = 0m;    // How much money already spent today

        // This method is called when someone wants to make a payment/spend money
        public void MakeTransaction(decimal amount)
        {
            // Check if amount is negative or zero (not allowed)
            if (amount <= 0)
            {
                throw new ArgumentException("Transaction amount must be greater than zero.");
            }

            // Very important check - have we crossed daily limit?
            if (totalTransactionsToday + amount > dailyLimit)
            {
                // Here we throw our custom error!
                throw new DailyLimitExceededException(
                    $"Daily limit exceeded! Limit: {dailyLimit}, " +
                    $"Already used: {totalTransactionsToday}, " +
                    $"Trying to spend: {amount}");
            }

            // If we reach here → everything is okay!
            totalTransactionsToday += amount;           // Add this amount to today's total

            // Show success message
            Console.WriteLine($"Transaction of {amount} completed successfully.");
            Console.WriteLine($"Remaining limit today: {dailyLimit - totalTransactionsToday}\n");
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