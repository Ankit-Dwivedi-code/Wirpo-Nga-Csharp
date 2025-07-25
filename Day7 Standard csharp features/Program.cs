using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Day7_Standard_csharp_features;

namespace Demo_Standard_C_Sharp_features
{
    //C#7.0 features 
    //Extension Methods  in C# 
    //Extension methods allow you to add new methods to existing types without modifying their source code.
    public static class StringExtensions
    {
        // This is an extension method for the string class that checks if a string is a palindrome.
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            var reversed = new string(str.Reverse().ToArray());
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }
        // This is an extension method for the string class that counts the number of vowels in a string.
        public static bool Iscapitalized(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            return char.IsUpper(str[0]);
        }
        // This is an extension method for the string class that counts
        // the number of vowels in a string.
        public static int CountVowels(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            return str.Count(c => "aeiouAEIOU".Contains(c));
        }
        // This is an extension method for the string class that reverses a string.



        //Tuples and Deconstrunction in C# 7.0
        //To group mulitple values into a siongle compund value, without defining the sperate class/struct ex (sring, int) GetPersonInfo("Raj",30)
        //To unpack tuple value( or other type) directly into a sperate variable, improving readability and intent clarity. 
        //var (name, age)  = GetpersonInfo();
        // ex Console.Writeline($"name: {Name}, Age: {age}");

        public static (int sum, int Product) CalculateSumAndProduct(this int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return (0, 0);
            int sum = numbers.Sum();//calculating sum
            int product = numbers.Aggregate(1, (acc, n) => acc * n);//calculating product
            return (sum, product); // returning sum and product
        }



        //Use case based on above C# 7.0 features

    }

    //Pattern Matching in C#
    public class PaternMatchingDemo
    {
        void PrintTypes(Object obj)
        {
            if (obj is int i)
            {
                Console.WriteLine($" Integer: {i}");
            }
            else if (obj is double d)
            {
                Console.WriteLine($"Double: {d}");
            }

            else if (obj is string s)
            {
                Console.WriteLine($"String:{s}");
            }
            else
                Console.WriteLine(" Unknown Types...!!! ");
        }

    }

    public class LocalFunction
    {
        void CalculateAndDisplay(int x, int y)
        {
            int Add(int a, int b) => a + b;//local function
            Console.WriteLine($" Addition Result : {Add(x, y)}");
        }
    }

    public class RefandOUT_variables
    {
        public static ref int FindFirstEven(ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    return ref numbers[i]; //ref will return the ref of the number
                }
            }
            throw new Exception(" no even number found");
        }

    }

    public class StudentExpression_Bodied_Menber
    {
        private string _name;
        public StudentExpression_Bodied_Menber(string name) => _name = name;

        public string GetName() => _name; // expresion-bodied method
        public string Display => $"Student Name : {_name}"; // expression-bodied property

    }

    internal class Program : Employee
    {
        static void Main(string[] args)
        {

            //Extension Methods  in C# 
            //Extension methods allow you to add new methods to existing types without modifying their source code.


            //Discard(_)
            // A discard is a write-only variable
            // tuple deconstuction
            // out parameters
            // paterns matching
            // Switch expressions 
            //async result
            //if (int.TryParse("456",out _))// i am intentionally ignoring this value 
            //{
            //    Console.WriteLine(" Parsing scucceeded ( Value discarded)");

            //}
            //// (string name, _ ) = ("Rahul", 26)//discard Age
            ////Console.WriteLine(name);
            // ( string Fname, string LName, int age) GetPerson() => ("Ria","kumari",24);
            // var (_,_, personAge) = GetPerson();//Discarded Firstname and lastname
            //Console.WriteLine($"Age:{personAge}");

            var (_, age, role) = GetEmployee();
            DisplayRole(role);

            Console.WriteLine($"Experience: {CalculateExperience(2014)} years ");
            Console.WriteLine("manager".ToTitleCase());
            if (int.TryParse("29", out int empAge)) // out parameter
            {
                Console.WriteLine($"Age Varified: {empAge}");
            }


            Employee emp = new Employee { Name = "Rahul", Role = "manager" }; // creating object of the class 
            Console.WriteLine(emp.Info); // calling class memebers to display data 

            int[] salaries = { 30000, 45000, 60000 };
            ref int targetSalary = ref Find(ref salaries, 45000);
            targetSalary = 70000;
            Console.WriteLine($"Updated salary: {salaries[1]}");

        }// main ends here ---------------------------
         //Methods implemntation
        new static (string, int, string) GetEmployee() => ("Tarun", 29, "Developer");
        static void DisplayRole(string Role)
        {
            if (Role is " Manager")
            {
                Console.WriteLine("Welcome, Manager ..!!");
            }
            else if

                 (Role is "Developer")
                Console.WriteLine("Welcome Developer ..!! ");
            else
                Console.WriteLine("Welcome, Staff.. !! ");
        }

        static int CalculateExperience(int joinYear) // 
        {
            int Current() => DateTime.Now.Year;//current year is claculated using local function
            return Current() - joinYear;
        }

        public static ref int Find(ref int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return ref arr[i];
                }
            }
            throw new Exception(" Value not found ..!!");

        }




    }
}