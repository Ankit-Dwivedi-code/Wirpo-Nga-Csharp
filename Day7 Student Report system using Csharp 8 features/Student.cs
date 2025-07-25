using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Student_Report_system_using_Csharp_8_features
{
    // As a school administrator, T want to create a lightweight report generation system
    // Objectives of the systems will be as follow:
    // 

    public interface IReport //Here we are defining default interface method
    {
        void GenerateReport(List<Student> students);

        void PrintTitle() => Console.WriteLine("\n Student report...\n");
        


    }
    public class Student
    {
        public int Id { get; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public int Marks { get; set; }

        //Constructor
        public Student(int id, string name, int marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }

    }

    public class ReportGenerator : IReport
    {
        public async IAsyncEnumerable<Student> LoadStudentAsync() //Here async is used for asyncronous communication and IAsyncEnumerator is used for enumerating type of collection values
        {
            //IEnumarable<student> is a interface in C# that represent a sequence of Student objects that can be enumerated (Iterated over)
            var students = new List<Student>
            {
                new Student(1, "Dhoni", 99),
                new Student(2, "Virat", 78),
                new Student(3, "Raina", 88),
                new Student(4, "Yuvraj", 92),

            };

            foreach (var student in students)
            {
                await Task.Delay(300); //Simulating Data fetch
                yield return student; // yield is used to implement itreator method to return element 1 at a time
            }

        }

        public async void GenerateReport( List<Student> students)
        {
            ((IReport)this).PrintTitle();
            

            foreach (var student in students)
            {
                string grade = student.Marks switch
                {
                    >= 90 => "A",
                    >= 75 => "B",
                    >= 60 => "C",
                    _ => "D"
                };
                Console.WriteLine($"{student.Name, -10 } | Marks: {student.Marks, -3} | Grade: {grade}"); //-10 and -3 are not of char we want to display
            }
        }
    }

    public static class ReportUtils  //Implementing range and indices to get top 3 students
    {
        public static List<Student> GetTopPerformers(List<Student> students)
        {
            var sorted = students.OrderByDescending(s => s.Marks).ToList();
            return sorted[..3]; //using range to slice top 3 values
        }
    }

    //Creating a class for exporting report

    public static class ExportHelper
    {
        public static void ExportReport(List<Student> students)
        {
            using var writer = new StreamWriter("StudentReport.txt");
            writer.WriteLine("Name\t Marks");
            foreach (var s in students)
            {
                writer.WriteLine($"{s.Name} \t {s.Marks}");
            }

            Console.WriteLine("\n ");
        }
    }
}
