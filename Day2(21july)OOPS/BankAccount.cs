using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class_and_Objects_SRP_OOPs
{
    internal class BankAccount//INternal visibility scope means this class is accessible only within the same assembly.
    {
        //Step 1: Fields
        //Static members are shared across all instances of the class.
        //Constructors 
        //property : get and Set accessors like Balance, AccountNumber, AccountHolderName
        //Methods Diposit, Withdraw, GetBalance 
        //static method to show interest rate

        private string accounHolderName;
        private double balance;

        private static double interestRate = 0.05; // Static member shared across all instances
        public BankAccount(string name, double initialBalance)
        {
            accounHolderName = name;
            balance = initialBalance;
        }
        //syntax for defing propery in C# is 
        //public <type> <propertyName> { get; set; }
        //anything defined as property is a member of the class that can be accessed like a field but has
        //additional functionality like validation or logic in the get/set accessors.
        public string AccountHolderName
        {
            get { return accounHolderName; }
            set { accounHolderName = value; }//value is the new value being assigned to the property at run time
        }
        public double Balance // read only property for balance hence we dont need to define a method to get balance
        {
            get { return balance; }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;//+= operator is used to add the amount to the current balance
                Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
                //string interpolation is used to format the output
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount; //-= operator is used to subtract the amount from the current balance
                Console.WriteLine($"Withdrawn: {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
        public static double GetInterestRate() // Static method to get interest rate as
                                               // only static members can be accessed without an instance of the class
        {
            return interestRate;
        }//only static members can be accessed without an instance of the class by static methods using static members

    }
}