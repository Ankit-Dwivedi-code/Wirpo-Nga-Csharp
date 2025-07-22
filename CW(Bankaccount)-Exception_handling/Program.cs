using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Bankaccount__Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a bank account with an initial balance

            BankAccount account = new BankAccount(1200);
            //BankAccount account2 = new BankAccount(1200);
            try
            {
                // Attempt to withdraw an amount greater than the balance
                account.Withdraw(200);
                
            }
            catch (InsufficientBalanceException ex)
            {
                // Handle the exception
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Display the current balance
                Console.WriteLine($"Current Balance: {account.Balance}");
            }
        }
    }

    public class BankAccount
    {
        public decimal Balance { get; private set; }
        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
            Balance = initialBalance;
        }
        public void Withdraw(decimal amount)
        {
            Console.WriteLine("Withdraw initiated with amount {0}", amount);
            if (amount > Balance)
            {
                throw new InsufficientBalanceException("You have insufficient amount to withdraw!!!");
            }
            Balance -= amount;
        }

       
    }
}
