using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;  // For showing metadata and types at runtime

namespace Day7_Reflection_in_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This feature allow us to inspect and interact with metadata, types, properties, mthods and assemblies at runtime.
             
            Type studentType = typeof(Student); // Here student type is of type student class

            Console.WriteLine("Class Name: " + studentType.Name); // Displaying class name

            Type Employee = typeof(Emp); // Here employee type is of type employee class
            Console.WriteLine("Class Name: " + Employee.Name); // Displaying class name

            //Fileds
            Console.WriteLine("Here are the list of fields in a following type");
            foreach (var field in studentType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($" --{field.Name} and type {field.FieldType}" );
            }

            // Reading Properties name and type from user defined class
            Console.WriteLine("Here are the list of properties in a following type");
            foreach (PropertyInfo property in studentType.GetProperties())
            {
                Console.WriteLine($" --{property.Name} and type {property.PropertyType}");
            }

            // Constructors from my class 
            Console.WriteLine("Here are the list of constructors in a following type");
            foreach (ConstructorInfo ctor in studentType.GetConstructors())
            {
                foreach (ParameterInfo param in ctor.GetParameters())
                {
                    Console.WriteLine($" --{param.ParameterType.Name} and type {param.Name}");
                }
            }

            //Reading methods of a class
            Console.WriteLine("Here are the list of methods in a following type");
            foreach (MethodInfo method in studentType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Instance | BindingFlags.Public))
            {
                Console.WriteLine($" --{method.Name} and return type {method.ReturnType}");
                //foreach (ParameterInfo param in method.GetParameters())
                //{
                //    Console.WriteLine($"    Parameter: {param.Name}, Type: {param.ParameterType}");
                //}
            }
        }
    }
}
