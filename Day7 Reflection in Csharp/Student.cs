using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Reflection_in_Csharp
{
    public class Student
    {
        private int id;
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int id, string name, int age)
        {
            this.id = id;
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {id}, Name: {Name}, Age: {Age}");
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return Name;
        }
    }

    public class Emp
    {
        private int empId;
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public Emp(int empId, string empName, int empAge)
        {
            this.empId = empId;
            EmpName = empName;
            EmpAge = empAge;
        }
        public void DisplayEmpInfo()
        {
            Console.WriteLine($"Employee ID: {empId}, Name: {EmpName}, Age: {EmpAge}");
        }
        public int GetEmpId()
        {
            return empId;
        }
        public string GetEmpName()
        {
            return EmpName;
        }
    }
}
