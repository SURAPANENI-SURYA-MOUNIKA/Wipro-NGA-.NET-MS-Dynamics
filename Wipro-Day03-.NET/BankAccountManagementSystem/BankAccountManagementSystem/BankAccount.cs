using System;

namespace BankAccountManagementSystem
{
    /// <summary>
    /// Base class for all types of bank accounts (Core Banking Assembly)
    /// </summary>
    public class BankAccount
    {
        // Completely hidden from outside world (even derived classes)
        private string accountPIN;

        // Accessible from everywhere (public API)
        public string accountNumber;

        // Accessible only in derived classes (for interest calculation etc.)
        protected decimal balance;

        // Accessible in derived classes + same assembly (protected internal)
        protected internal decimal interestRate;

        // Accessible only inside the same assembly (BankAudit project can't access directly)
        internal string bankBranchCode;

        /// <summary>
        /// Constructor to initialize bank account
        /// </summary>
        public BankAccount(string accNumber, string pin, decimal interest, string branchCode)
        {
            accountNumber = accNumber;      // public field
            accountPIN = pin;               // private - hidden
            interestRate = interest;        // protected internal
            bankBranchCode = branchCode;    // internal
            balance = 0m;                   // starting balance = 0
        }

        /// <summary>
        /// Deposit money into account
        /// </summary>
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Deposit amount must be positive!");
                return;
            }

            balance += amount;
            Console.WriteLine($"Successfully deposited {amount:C}. New balance: {balance:C}");
        }

        /// <summary>
        /// Just for checking balance (only for demo - normally you would have authentication)
        /// </summary>
        public decimal GetBalance()
        {
            return balance;
        }
    }
}