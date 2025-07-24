using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;// System.Text.Json is used for JSON serialization and deserialization

namespace Demo_File_Handling_Operations
{
    public class Employee
    {
        //What will be he steps for creating  EMS: Emoployee Management System using file handling operations in C# like below 
        //Add Employee details
        //View All employees
        //Search by ID
        //Update any employee salary
        //Delete employee by ID
        //save and load from the file 

        // Step 1: Create a class to represent an Employee with properties like ID, Name, and Salary
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        // Step 2: Create a constructor to initialize the Employee object
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        //defining a class variable of type collection to hold employees
        public static List<Employee> Employees = new List<Employee>();
        string filePath = "employees.json"; // File path to save employee details

        // Step 3: Override ToString() method to display employee details
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary:C}";
        }
        // Step 4: Create a method to save employee details to a file
        public void SaveToFile(string filePath)
        {
            using (var writer = new System.IO.StreamWriter(filePath, true)) // Append mode so that we can add multiple employees
            {
                writer.WriteLine($"{Id},{Name},{Salary}");
            }
        }
        // Step 5: Create an Add Employee method to add an employee
        public static void AddEmployee(List<Employee> employees, string filePath)
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Employee employee = new Employee(id, name, salary);
            employees.Add(employee);
            employee.SaveToFile(filePath);
            Console.WriteLine("Employee added successfully.");
        }
        // Step 6: Create a method to view all employees
        public void ViewAllEmployees(List<Employee> employees)
        {
            Console.WriteLine("Employee List:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
        // Step 7: Create a method to search for an employee by ID
        void SearchByID()
        {
            Console.WriteLine("Enter Employee ID to search: ");
            int searchId = int.Parse(Console.ReadLine());
            var employee = Employees.FirstOrDefault(e => e.Id == searchId);//This will start from the first employee and search for the employee wi
                                                                           //==> Operator is used to compare the ID of the employee with the searchId
                                                                           //e=> e.ID == id: this lambda expression represents the condition 
            if (employee != null)
                Console.WriteLine(employee);
            else
                Console.WriteLine("Employee not found.");                                                                                                                      //}

        }

        //Step 8: Create a method to update employee salary
        public void UpdateSalary()
        {
            Console.WriteLine("Enter Employee ID to update salary: "); // Asking user to enter the ID of the employee whose salary needs to be updated
            int searchId = int.Parse(Console.ReadLine());
            var employee = Employees.FirstOrDefault(e => e.Id == searchId);// Using LINQ to find the employee by ID
            if (employee != null)
            {
                Console.Write("Enter new Salary: ");
                decimal newSalary = decimal.Parse(Console.ReadLine());
                employee.Salary = newSalary;
                Console.WriteLine("Salary updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        //Step 9: Create a method to delete an employee by ID
        public void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee ID to delete: ");// Asking user to enter the ID of the employee to be deleted
            int searchId = int.Parse(Console.ReadLine());
            var employee = Employees.FirstOrDefault(e => e.Id == searchId);
            if (employee != null)
            {
                Employees.Remove(employee);
                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        // Step 10: Create a method to save emp details to file 
        public void SaveEmployeesToFile()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(Employees);// Serializing the list of employees to JSON format
            File.WriteAllText(filePath, json);// Writing the JSON string to the file ie JavaScript Object Notation format ideal for storing structured data
            Console.WriteLine(" Data Saved to file Sucessfully..!!!");
        }
        // Step 11: Create a method to load employee details from file
        public  void LoadEmployeesFromFile()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                Employees = JsonSerializer.Deserialize<List<Employee>>(json);
                Console.WriteLine("Employees loaded successfully.");
            }
            else
            {
                Console.WriteLine("No saved data found.");
            }
        }

        // Step 12: Create a method to display the menu and handle user input   
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View All Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Update Employee Salary");
            Console.WriteLine("5. Delete Employee by ID");
            Console.WriteLine("6. Save Employees to File");
            Console.WriteLine("7. Load Employees from File");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            Employee employee = new Employee(0, "", 0); 

            switch (choice)
            {
                case 1:
                    AddEmployee(Employees, "employees.txt");
                    break;
                case 2:
                    employee.ViewAllEmployees(Employees);
                    break;
                case 3:
                    employee.SearchByID();
                    break;
                case 4:
                    employee.UpdateSalary();
                    break;
                case 5:
                    employee.DeleteEmployee();
                    break;
                case 6:
                    employee.SaveEmployeesToFile();
                    break;
                case 7:
                    employee.LoadEmployeesFromFile();
                    break;
                case 0:
                    Console.WriteLine("Exiting the program.");
                    return; // Exit the method to stop the loop
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }


    }

}

