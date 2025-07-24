using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day4_Assignment_Ques3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("=== Mini File Reader App ===");
                Console.Write("Enter the full path of the file to read: ");
                string filePath = Console.ReadLine();
                if (!File.Exists(filePath))
                {
                    throw new CustomError("CustomError: File path not found!");
                    Console.ReadLine();
                }

                Console.WriteLine("\n--- File Contents ---\n");
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);



                Console.ReadLine();



            }
            catch (CustomError ce)
            {
                Console.WriteLine(ce.Message);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied. You don't have permission to read this file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
