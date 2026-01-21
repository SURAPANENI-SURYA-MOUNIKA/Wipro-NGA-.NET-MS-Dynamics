using System;
using BankAccountManagementSystem;     // For SavingAccount & BankAccount
using BankAudit;                      // For CorporateAccount

namespace BankAccountManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("   WELCOME TO BANK MANAGEMENT SYSTEM   ");
            Console.WriteLine("=====================================\n");

            // Creating sample accounts
            SavingAccount saving = new SavingAccount("SA001", "1234", 4.5m, "BR-VJA-01");
            CorporateAccount corporate = new CorporateAccount("CA001", "9999", 6.0m, "BR-HYD-02");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== MAIN MENU ===");
                Console.WriteLine("1. Deposit to Savings Account");
                Console.WriteLine("2. Calculate & Add Interest (Savings)");
                Console.WriteLine("3. Check Savings Balance");
                Console.WriteLine("4. Deposit to Corporate Account");
                Console.WriteLine("5. Apply Corporate Interest");
                Console.WriteLine("6. Check Corporate Balance");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice (0-6): ");

                string choice = Console.ReadLine();

                Console.WriteLine("-------------------------------------");

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depAmt))
                            saving.Deposit(depAmt);
                        else
                            Console.WriteLine("Invalid amount!");
                        break;

                    case "2":
                        saving.AddInterest();
                        break;

                    case "3":
                        Console.WriteLine($"Savings Account ({saving.accountNumber}) Balance: {saving.GetBalance():C}");
                        break;

                    case "4":
                        Console.Write("Enter deposit amount for Corporate: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal corpDep))
                            corporate.Deposit(corpDep);
                        else
                            Console.WriteLine("Invalid amount!");
                        break;

                    case "5":
                        corporate.ApplyCorporateInterest();
                        break;

                    case "6":
                        Console.WriteLine($"Corporate Account ({corporate.accountNumber}) Balance: {corporate.GetBalance():C}");
                        break;

                    case "0":
                        Console.WriteLine("\nThank you for using Bank Management System. Goodbye!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please select 0-6.");
                        break;
                }
            }
        }
    }
}