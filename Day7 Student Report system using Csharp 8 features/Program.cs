// See https://aka.ms/new-console-template for more information
using Day7_Student_Report_system_using_Csharp_8_features;

Console.WriteLine("Hello, World!");



    var generator = new ReportGenerator();  // Creating object

    var students = new List<Student>();

    await foreach (var s in generator.LoadStudentAsync())
    {
        students.Add(s); // this will iterate through the values 
    }

    var top3 = ReportUtils.GetTopPerformers(students);
    generator.GenerateReport(top3); //Passing top 3 values of the collections

    ExportHelper.ExportReport(top3);
