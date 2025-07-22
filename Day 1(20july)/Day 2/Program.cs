using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("here we can understand diff between implicit and explicit conversion in .NET ");
            // Implicit conversion

            int intValue = 123;
            long longValue = intValue; // Implicit conversion from int to long
            Console.WriteLine($"Implicit conversion: int {intValue} to long {longValue}");

            double doubleValue = longValue; // Implicit conversion from long to double
            Console.WriteLine($"Implicit conversion: long {longValue} to double {doubleValue}");
            // Explicit conversion

            double anotherDoubleValue = 123.456;
            int anotherIntValue = (int)anotherDoubleValue; // Explicit conversion from double to int
            Console.WriteLine($"Explicit conversion: double {anotherDoubleValue} to int {anotherIntValue}");
            // Note: The explicit conversion truncates the decimal part, so 123.456 becomes 123.

            //Convert.ToInt32(), int.Parse(), .ToString()


            Console.WriteLine(" there are different ways of explicit conversion : ");
            string stringValue = "456";
            int parsedIntValue = int.Parse(stringValue); // Using int.Parse
            Console.WriteLine($"Parsed int value: {parsedIntValue}");
            int convertedIntValue = Convert.ToInt32(stringValue); // Using Convert.ToInt32
            Console.WriteLine($"Converted int value: {convertedIntValue}");

            string anotherStringValue = 789.ToString(); // Using ToString
            Console.WriteLine($"String value from int: {anotherStringValue}");
            // multiple ways of converting into string 
            // Note: int.Parse and Convert.ToInt32 can throw exceptions if the string is not a valid integer.


        }
    }
}
