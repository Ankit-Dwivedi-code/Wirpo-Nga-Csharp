using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_22july_Abstract_instances
{
    internal interface IPaymentGateway
    {

        //here we will declare the methods that will be implemented in the derived classes O references
        void Pay(decimal amount);
        void Refund(decimal amount);
        //Incase or interface all methods are abstract by default, meaning they do not have a body. 
        //Interfaces cannot have fields or properties with implementation, only method signatures. 
        //We can create reference to an interface type, but we cannot instantiate it directly. 
        //ex IPaymentGateway paymentGateway = new IPaymentGateway(); 
        // This will give an error 
        // But we can create a reference to a class that implements the interface ex
        // IPaymentGateway paymentGateway = new CreditCardPayment();
    }

    // define class that implements the interface

    public class PayPalGateway : IPaymentGateway
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"PayPal payment of {amount} made successfully.");
        }
        public void Refund(decimal amount)
        {
            Console.WriteLine($"PayPal refund of {amount} processed successfully.");
        }
    }
}
