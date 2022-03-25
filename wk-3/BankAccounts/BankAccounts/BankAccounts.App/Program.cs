using System;
using System.IO;

namespace BankAccounts
{
    class Program
    {
        static void Main()
        {
            SavingsAccount newSavingsAccount = new SavingsAccount("Personal Savings", 2500.00);
            Console.WriteLine("newAccount.Name = " + newSavingsAccount.accountName);

            //testing the ApplyInterest method
            newSavingsAccount.ApplyInterest();
            Console.WriteLine("Current account balance: " + newSavingsAccount.GetAccountBalance());

            CheckingAccount newCheckingAccount = new CheckingAccount("Personal Checking", 2500.00);

            Console.WriteLine("newAccount.AccountName = " + newCheckingAccount.accountName);
            Console.WriteLine("Current account number: " + newCheckingAccount.GetAccountNumber());
            Console.WriteLine("Current account balance: " + newCheckingAccount.GetAccountBalance());
            Console.WriteLine("Current interest rate: " + newCheckingAccount.GetInterestRate());

            Console.WriteLine("Current account balance: " + newCheckingAccount.GetAccountBalance());

            newCheckingAccount;
            newSavingsAccount;            
        }
    }
}