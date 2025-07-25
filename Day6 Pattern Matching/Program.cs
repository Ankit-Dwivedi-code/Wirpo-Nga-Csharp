using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEmo_PaternMatching_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here the objectiove is to use pattern matching with switch statement
            //ex if user enters a sentence like I am a SME who is Microsoft certified and been training candioated since 2010
            //Our code should match words like 
            //Python, java, .NET : -> Technology
            //Microsoft, Google, Amazon: -> Company
            //SME, Trainer, Developer: -> Role
            //2020, 2010, 2019: -> Year
            Console.WriteLine(" Here is my pattern matching App using Switch case ");
            Console.WriteLine("Type 'exit' to Quit\n ");
            while (true)//it is a infinite loop
            {
                Console.WriteLine(" Enter a sentence: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Thank you for using the application ");
                    break; // exit the loop if user types exit
                }
                // Now we will use switch statement with pattern matching
                //Step 1: Define the pattern to match

                string[] words = input.Split(' ');
                bool found = false;// flag to check if any match is found

                foreach (string word in words)
                {
                    switch (word.ToLower())
                    {
                        case "python":
                        case "java":
                        case ".net":
                            Console.WriteLine($"->Entity: {word} is a Technology");
                            found = true;
                            break;
                        case "microsoft":
                        case "google":
                        case "amazon":
                            Console.WriteLine($"->Entity:{word} is a Company");
                            found = true;
                            break;
                        case "sme":
                        case "trainer":
                        case "developer":
                            Console.WriteLine($"->Entity:{word} is a Role");
                            found = true;
                            break;
                        case "2010":
                        case "2019":
                        case "2020":
                            Console.WriteLine($"->Entity:{word} is a Year");
                            found = true;
                            break;
                        default:
                            // If no match found, we can ignore or handle it
                            break;
                    }
                }
            }
        }
    }
}