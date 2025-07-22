using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Step 1: Include the System.IO namespace

namespace Demo_File_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Following are the stepos for implementing File handling in C#");
            //Step 1: Include the System.IO namespace
            //Step 2: Use the File class to create, read, write, and delete files
            // Step 3: Use the Directory class to create, delete, and enumerate directories
            // Step 4: Use the Path class to manipulate file and directory paths
            // Step 5: Handle exceptions that may occur during file operations
            // Step 1: Define the file path
            string filePath = @"E:\wipro\FileHandling(22july)\example.txt";
            //here i am passing absolute path of the file to be created
            // Ensure the directory exists, Using @ to avoid escape sequences in the file path

            //file path can be relative also like "example.txt" if you want to create it in the current directory
            //There is one more way  to create path using Path.Combine method
            //string folderPath = @"C:\Users\Parth\source\repos\Wipro .NET with react cohort\Week 1 C# Demo\Day 4 Demo Absract class, Interface, exception handling\Demo_File_handling";
            //string fileName = "example.txt";
            //string combinedPath = Path.Combine(folderPath, fileName); //using this avoid manual string concatenation

            try
            {
                File.WriteAllText(filePath, "Hello, World! This is my first file handling demo in C#");
                // Step 2: Create and write to a file
                Console.WriteLine("File created and written successfully.");

                string content = File.ReadAllText(filePath); // Step 3: Read the content of the file
                Console.WriteLine("File content: " + content);

                //Step 4: Append text to the file( here we can take input from the user also)
                Console.WriteLine(" Ener any ext message that you want to append in the file ...!!");
                string appendText = Console.ReadLine();
                File.AppendAllText(filePath, "\n" + appendText + DateTime.Now); // \n is used to add a new line before appending
            }
            catch (FileNotFoundException fnfEx)
            {
                Console.WriteLine("The file was not found: " + fnfEx.Message);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("An I/O error occurred: " + ioEx.Message);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                Console.WriteLine("You do not have permission to access this file: " + uaEx.Message);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.WriteLine(" File handling  Operations in  Action ...!! ");
            }
        }
    }
}