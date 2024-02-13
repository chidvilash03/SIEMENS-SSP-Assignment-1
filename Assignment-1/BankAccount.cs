using System;

namespace BankAccountNameSpace
{
    //Define the BankAccount class
    class BankAccount
    {
        //Properties
        string bankAccountNumber;
        string bankAccountHolder;
        double balance = 0;

        //constructor
        public BankAccount(string accountNumber, string accountHolder, float bankBalance)
        {
            bankAccountNumber = accountNumber;
            bankAccountHolder = accountHolder;
            balance = bankBalance;
        }

        //method to display account information
        public void DisplayAccountInfo()
        {
            Console.WriteLine("Bank Account Information...");
            Console.WriteLine("Account Number: " + bankAccountNumber);
            Console.WriteLine("Account Holder: " + bankAccountHolder);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("\n");
        }

        //method to deposit
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposited : " + amount + ". New Balance : " + balance);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Invalid Deposit Amount");
                Console.WriteLine("\n");
            }
        }

        //method to withdraw
        public void WithDraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn amount : " + amount + ". New Balance : " + balance);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or Insufficient balance.");
                Console.WriteLine("\n");
            }

        }

    }

}