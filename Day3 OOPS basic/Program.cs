using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class_and_Objects_SRP_OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Following are the standard steps for implemting Classes and Objects in C#");
            Console.WriteLine("1. Define a class with properties and methods.");
            Console.WriteLine("2. Create an instance of the class (an object)."); // Instantiation
            Console.WriteLine("3. Access the properties and methods of the object using the dot (.) operator.");
            Console.WriteLine("4. Use the object to perform operations or retrieve data.");
            //We can also static and private members in a class.
            Console.WriteLine("5. Optionally, implement encapsulation, inheritance, and polymorphism for advanced OOP features.");

            Console.WriteLine("Creating Object of Bank Account class ");
            BankAccount account1 = new BankAccount("John Doe", 1000000.0);
            //accesing properties and methods of the object using the dot (.) operator
            Console.WriteLine($"Account Holder: {account1.AccountHolderName}");// Accessing property
            Console.WriteLine($"Initial Balance: {account1.Balance}"); // Accessing read-only property
            account1.Deposit(500.0); // Calling method to deposit money
            account1.Withdraw(200.0); // Calling method to withdraw money
            Console.WriteLine($"Current Balance: {account1.Balance}"); // Accessing read-only property again

            Console.WriteLine($"Interest Rate: {BankAccount.GetInterestRate()}"); // Accessing static method to get interest rate



        }
    }
}