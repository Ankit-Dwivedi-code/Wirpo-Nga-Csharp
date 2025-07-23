using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_22july_Abstract_instances
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Getting started with Abstract Class and Interface");
            Console.WriteLine("------------------------------------------");
            //makesound class which with predefined methods which can be derived in child classes 
            //Step 1: Create an abstract class
            //Step 2: Create an interface
            //Step 3: Implement the abstract class and interface in a derived class( Why? Because abstract classes cannot be instantiated directly) 
            //Step 4: Create an instance of the derived class and call the methods

            Console.WriteLine("Here is an abstract class demo......!!!.");
            // Step 1: Create an abstract class
            Payment payment = new CreditCardPayment(); // Creating an instance of the derived class
            payment.MakePayment(1000.00m); // Calling the abstract method implemented in the derived class
            payment.GenrateReceipt(); // Calling the concrete method from the abstract class


            Console.WriteLine("IMplementing Interface ");
            IPaymentGateway paymentGateway = new PayPalGateway(); // Creating an instance of the class that implements the interface
            paymentGateway.Pay(1500.00m); // Calling the Pay method from the interface
            paymentGateway.Refund(500.00m); // Calling the Refund method from the interface
            Console.WriteLine("--------------------------------------------------");


        }
    }
    class CreditCardPayment : Payment
    {
        public override void MakePayment(decimal amount)
        {
            // Implementation for credit card payment
            Console.WriteLine($"Credit Card Payment of {amount} made successfully. with {PaymentId}");
            PaymentId = Guid.NewGuid().ToString(); // Generate a unique Payment ID 
            //Guid.NewGuid() generates a new globally unique identifier (GUID) ex" TXN13254"


        }
    }
}
