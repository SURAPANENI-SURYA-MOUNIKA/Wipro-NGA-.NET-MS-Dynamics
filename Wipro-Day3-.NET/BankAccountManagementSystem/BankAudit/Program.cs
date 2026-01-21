using System;
using BankAccountManagementSystem;    // for SavingAccount
using BankAudit;                     // ← THIS LINE MUST WORK after adding reference

namespace BankAccountManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // ...
            CorporateAccount corpAcc = new CorporateAccount("CA123", "5678", 7.0m, "BR002");
            // ...
        }
    }
}