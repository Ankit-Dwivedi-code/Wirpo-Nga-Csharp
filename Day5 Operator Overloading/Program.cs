using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OperatorOverlaoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPerator overloading includes giving addittional meaning to operapors so that they can work on different data types apart from int");
            //Step 1: Create a class
            //Step 2: Create a method that overloads an operator(in this case, the + operator)
            //Step 3: Create an instance of the class and use the overloaded operator
            //Step 4: Observe the output
            // Defination : with the help of operator overloading, we can give additional meaning to operators so that they can work on different data types apart from int, float, double, etc.
            //Use: // Operator overloading is used to define custom behavior for operators when applied to user-defined types, allowing for more intuitive and readable code.

            //Creating objects of MyClass
            MyClass obj1 = new MyClass("Anurag kashyap");
            MyClass obj2 = new MyClass("Anurag basu");
            //testing operator overloading with above objects 
            MyClass obj3 = obj1 + obj2; // using overloaded + operator to concatenate names
            Console.WriteLine("Using overloaded + operator: " + obj3); // Output: Anurag Kumar
            //testing other operator overloading with same objects

            bool areEqual = obj1 == obj2; // using overloaded == operator to check equality
            Console.WriteLine("Using overloaded == operator: " + areEqual); // Output: False

            bool areNotEqual = obj1 != obj2; // using overloaded != operator to check inequality
            Console.WriteLine("Using overloaded != operator: " + areNotEqual); // Output: True
            // Overriding ToString method to display the name of the MyClass instance
            Console.WriteLine("Using overridden ToString method: " + obj1); // Output: Anurag Kashyap
            Console.WriteLine("Using overridden ToString method: " + obj2); // Output: Anurag Basu

            // Overriding Equals method to compare two MyClass instances
            bool isEqual = obj1.Equals(obj2); // using overridden Equals method to compare instances
            Console.WriteLine("Using overridden Equals method: " + isEqual); // Output: False

            // Overriding GetHashCode method to return the hash code of the name of the MyClass instance
            int hashCode = obj1.GetHashCode(); // using overridden GetHashCode method to get the hash code
            int hashCode2 = obj2.GetHashCode(); // using overridden GetHashCode method to get the hash code of another instance
            Console.WriteLine("Using overridden GetHashCode method for firs object : " + hashCode); // Output: Hash code of the name
            Console.WriteLine("Using overridden GetHashCode method for second object : " + hashCode2); // Output: Hash code of the name


        }
    }
}