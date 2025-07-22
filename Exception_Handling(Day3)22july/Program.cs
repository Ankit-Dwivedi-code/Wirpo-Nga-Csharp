using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Exception_Handling;

namespace Exception_Handling_Day3_22july
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In c# we can handle exception by try catch and finally block

            // without try catch block
            //int x = 22;
            //int y = 0;
            //Console.WriteLine(x / y);

            // with try catch block
            /* try
             {
                 int x = 22;
                 int y = 0;
                 Console.WriteLine(x / y);
             }
             catch (DivideByZeroException ex)
             {
                 Console.WriteLine("You cannot divide by zero.");
                 Console.WriteLine(ex.Message);
             }
             catch (Exception ex)
             {
                 Console.WriteLine("An error occurred: " + ex.Message);
             }
             finally
             {
                 Console.WriteLine("This block always executes, regardless of an exception.");
             }*/
            //Step 1: We are creating an instance of OrderProcessor class
            OrderProcessor orderProcessor = new OrderProcessor();
            //Step 2: We are calling the PlaceOrder method with productId, Quantity and orderAmount
            orderProcessor.PlaceOrder("Smart phone", 2, 1000.00m);
            orderProcessor.PlaceOrder("Gaming PC", -1, 2000.00m);
            orderProcessor.PlaceOrder("Gaming PC", 2, 2000.00m);
            orderProcessor.PlaceOrder("Smart Watch", 1, 500.00m);
            Console.WriteLine();
        }
    }
}
