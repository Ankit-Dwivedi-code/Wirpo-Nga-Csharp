using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Day6_File_handling_streams
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // In file handling we have File streams which a implemented via Stream
            //Serialization which is implemented via System.Text.Json
            //Deserialization which is implemented via System.Text.Json
            //Why: It is used whenever we want to read or write data to a file in a structured way, such as reading a text file, writing to a binary file, or

            //Folllowing are trhe steps to handle files in C#: 
            //Step 1: Create a file stream using FileStream class ex FileStream fileStream = new FileStream("example.txt", FileMode.Create);
            //Step 2: Use the stream to read or write data using StreamReader or StreamWriter classes.
            //Step 3: Close the file stream to release resources.( It is very imp to relase resources after using file streams to avoid memory leaks and file locks.)
            //Step 4: Use try-catch blocks to handle exceptions that may occur during file operations, such as file not found or access denied.


            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "John Doe", "HR"),
                new Employee(2, "Jane Smith", "IT"),
                new Employee(3, "Sam Brown", "Finance")
            };

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "employees.json");

            //Step1: 

            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fileStream, employees);
                Console.WriteLine("Employees data written to the file successfully ..!!!");
            }

            //Step 5: Read and Deserialize using FileStream
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                List<Employee> LoadedEmployees = JsonSerializer.Deserialize<List<Employee>>(fileStream);
                Console.WriteLine("Employees data read from the file successfully ..!!!");

                foreach (var emp in LoadedEmployees)
                {
                    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}");
                }
            }





        }
    }
}
