using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Demo_File_Handling_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Management System (EMS)!");
            Console.WriteLine("-----------------------------------------------");

            // Load employee data from file before starting the menu loop
            Employee empInstance = new Employee(0, "", 0);
            empInstance.LoadEmployeesFromFile();

            // Show menu in a loop until the user chooses to exit
            while (true)
            {
                Employee.DisplayMenu();
                Console.WriteLine();
            }


        }
    }
}