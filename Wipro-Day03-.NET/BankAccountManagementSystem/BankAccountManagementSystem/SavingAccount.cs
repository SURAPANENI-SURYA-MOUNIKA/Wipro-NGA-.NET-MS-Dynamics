using System;

namespace BankAccountManagementSystem
{
    /// <summary>
    /// Savings Account - inherits from BankAccount
    /// Can access: public, protected, protected internal members
    /// </summary>
    public class SavingAccount : BankAccount
    {
        public SavingAccount(string accNumber, string pin, decimal interest, string branchCode)
            : base(accNumber, pin, interest, branchCode)
        {
            // Nothing extra needed here - just calling base constructor
        }

        /// <summary>
        /// Calculate interest for savings account (simple interest)
        /// Uses protected 'balance' and protected internal 'interestRate'
        /// </summary>
        public decimal CalculateInterest()
        {
            decimal interestAmount = balance * (interestRate / 100);
            return interestAmount;
        }

        /// <summary>
        /// Add calculated interest to balance
        /// </summary>
        public void AddInterest()
        {
            decimal interest = CalculateInterest();
            balance += interest;
            Console.WriteLine($"Interest added: {interest:C}. New balance: {balance:C}");
        }
    }
}