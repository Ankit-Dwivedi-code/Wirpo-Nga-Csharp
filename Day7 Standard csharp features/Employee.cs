using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Standard_csharp_features
{
    internal class Employee
    {
        // Help an HR department build a lightweight employee information system using C# 7.O features only
        // Following are some user stories from a HR perspective:
        //Store employee information such as name, age, and role.
        //Filter employees by role.(using pattern matching)
        //Extract and Display just specific information about employees (using tuples & deconstruction).
        //Calculate experince using Local functions.
        //Extent string data(Extensions methods).
        // use out variables to validate age
        //Ignore unwanted data using discard variables.
        //Use concise methods(Expressin-bodied members) to simplify code.

        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

        public string Info => $"{Name}, {Age} years old, works as {Role}";

        //public string GetEmployee() => $"{Name} is a {Role} aged {Age}.";
    }

    public static class EmpStringExtensions
    {
        public static string ToTitleCase( this string str) => char.ToUpper(str[0]) + str.Substring(1).ToLower();
    }
}
