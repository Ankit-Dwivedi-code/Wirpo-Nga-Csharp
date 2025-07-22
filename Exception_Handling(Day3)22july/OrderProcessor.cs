using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exception_Handling
{
    //Step 4: We are creating a custom exception for inventory check
    public class InventoryCheckException : Exception
    //When we want to create a custom exception, we need to inherit from the base Exception class
    {
        public InventoryCheckException(string message) : base(message)//message is passed to the base class constructor whi
        {
            Console.WriteLine(" Here is a inventory shortage, we will get back to you .. !!!");
        }
    }
    internal class OrderProcessor
    {
        //An online Shopping application processes orders placed by customers.
        //During check out process, multiple operartions  payemnt, inventory check, order confirmation etc. are performed.
        //They may face following exceptions:
        //INvalid User input Exception
        // Payment Failure Exception
        // Inventory Check Exception/out od stock Exception
        //Null refernce Exception
        //File not found udirng logging or invoice generation
        //A s developer , you need to handle these exceptions gracefully to ensure a smooth user experience.

        //user Story based on above sceanrio :
        //A  User tries to place an order for a product. the system must :
        //Validate the Order amounut and ensure it is a valid number.
        //Check if the product is in stock.// user define exception: 
        //Process the payment and handle any payment failures.
        //Genrate invoices and save to file system.
        //return a success message or an error message to the user.

        //Step 1: We are creaing a  inventory data via collecion  Dictionary<string, int>
        private Dictionary<string, int> inventory = new Dictionary<string, int>
        {
            { "Gaming PC", 1000 },
            { "Smart phone", 0 }, // Out of stock
            { "Smart Watch", 500 }
        };
        //Step 2: We are creating a method to process the order with fields like product name and order amount
        public void PlaceOrder(string productId, int Quantity, decimal orderAmount)
        {
            try
            {
                //here we are validating the order amount
                //Step 3: Calling the method to validate the order amount
                ValidateOrderAmount(orderAmount);
                //Step 4: Calling the method to check inventory
                CheckInventory(productId, Quantity);
                //Step 5: Calling the method to process payment
                ProcessPayment(orderAmount);
                Console.WriteLine("your Order is successfull placed ..!!!");
            }
            catch (ArgumentException ex)
            { Console.WriteLine($" Input Error {ex.Message}"); }

            catch (InventoryCheckException ex)
            {
                Console.WriteLine($" Inventory Error {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($" Payment Error {ex.Message}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($" Unexpected ERROR. !!!!{ex.Message}");
            }
            finally
            {
                // This block will always execute, regardless of whether an exception was thrown or not
                Console.WriteLine("Order attempted logged at." + DateTime.Now);
            }
        }

        //Step 3: We are creating a method to validate the order amount
        private void ValidateOrderAmount(decimal orderAmount)
        {
            if (orderAmount <= 0)
            {
                throw new ArgumentException("Order amount must be greater than zero.");//Predefine exception
            }
        }
        private void CheckInventory(string productId, int quantity)
        {
            //if (!inventory.ContainsKey(productId) || inventory[productId] < quantity)
            //{
            //   // throw new InvalidOperationException("Product is out of stock or insufficient quantity available.");
            //}
            if (!inventory.ContainsKey(productId) || inventory[productId] < quantity)// here we are chekcing for productId and quantity
            {
                //Step 4: Throwing custom exception for inventory check
                throw new InventoryCheckException($"Product '{productId}' is out of stock or insufficient quantity available.");
            }
        }
        //Step 5: We are creating a method to process payment
        private void ProcessPayment(decimal orderAmount)
        {
            // Simulating payment processing
            if (orderAmount > 1000) // Assuming payment fails for amounts greater than 1000
            {
                throw new InvalidOperationException("Payment failed due to insufficient funds.");
            }
        }

        // for genrating inovice we have to use file handling 


    }
}