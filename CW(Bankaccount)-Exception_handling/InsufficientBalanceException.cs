using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Bankaccount__Exception_handling
{

    //here we want to handle a n exception for insufficient balance in a bank account
    // you have to follow folllowing step for above implementation 
    //Step 1: Create a class that inherits from Exception
    //Step 2: Create a constructor that takes a message parameter and passes it to the base class constructor
    //Step 3: Optionally, you can add additional properties or methods if needed
    //Step 4: Use the custom exception in your code where you want to validate balance
    //Create a class with bank Account and a method to withdraw money
    //You r class shoul dhave Balance property with getter and  private setter
    internal class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
            //Console.WriteLine("You have insufficient balance to withdraw!!");
            //Console.WriteLine(message);
            //throw message;
        }
    }
}
