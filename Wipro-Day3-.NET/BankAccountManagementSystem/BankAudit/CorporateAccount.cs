using System;
using BankAccountManagementSystem;   // ← Must add reference to BankAccountManagementSystem project!

namespace BankAudit
{
    /// <summary>
    /// Corporate Account - in different assembly (BankAudit)
    /// Can access: public, protected, protected internal members
    /// CANNOT access: private, internal members
    /// </summary>
    public class CorporateAccount : BankAccount
    {
        public CorporateAccount(string accNumber, string pin, decimal interest, string branchCode)
            : base(accNumber, pin, interest, branchCode)
        {
            // Base constructor handles initialization
        }

        /// <summary>
        /// Corporate accounts get interest directly added (maybe yearly)
        /// Uses protected 'balance' and protected internal 'interestRate'
        /// </summary>
        public void ApplyCorporateInterest()
        {
            decimal interest = balance * (interestRate / 100);
            balance += interest;
            Console.WriteLine($"Corporate interest applied: {interest:C}. New balance: {balance:C}");
        }
    }
}