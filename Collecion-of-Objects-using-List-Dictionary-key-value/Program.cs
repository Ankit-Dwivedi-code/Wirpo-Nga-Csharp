using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Collecion_of_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Demo based on collection of objecs using list<T> and Dictionary<TKey,TValue>");
            Console.WriteLine(" How List<t> and Dictionary<tKey,Tvalue> are implemented ");
            Console.WriteLine(" What are the best use case of implementing above collections ");

            //Step 1: Create a list of Employee objects which is a collection of objects
            List<Employee> employees = new List<Employee>
            {
                new Employee(101, "Alice", "HR"),
                new Employee(102, "Bob", "IT"),
                new Employee(103, "Charlie", "Finance")
            };

            //Step 2: Display the list of employees
            Console.WriteLine("List of Employees:");
            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Id},Name : {item.Name}, Dept {item.Department}");
            }


            //Step 3: Create a dictionary to store employees by their ID this will help in quick lookups ex searching, sorting , etc.
            Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>();
            //Step 4: Populate the dictionary with employees data 
            foreach (var employee in employees)
            {
                employeeDictionary[employee.Id] = employee; // Add each employee to the dictionary using their ID as the key
            }

            //Step 6: Performing lookups using the dictionary ie searching for an employee by ID
            Console.WriteLine(" \n Enter an Employee ID to search:");
            int searchId = Convert.ToInt32(Console.ReadLine());

            if (employeeDictionary.TryGetValue(searchId, out Employee foundEmp))// here we are using TryGetValue method to search for an employee by ID
                                                                                //out parameter foundEmp will hold the employee object if found
                                                                                //searchId is the key we are looking for in the dictionary
            {
                Console.WriteLine($"Employee Found : {foundEmp.Name} and Emp Dept: {foundEmp.Department}");

            }
            else
            {
                Console.WriteLine($"Employee with ID {searchId} not found.");
            }
        }
    }

    public class Employee//Create a class Employee
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
}