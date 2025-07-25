using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello from .NET Core!");
        Console.WriteLine($"OS Description: {RuntimeInformation.OSDescription}");
        Console.WriteLine($"OS Architecture: {RuntimeInformation.OSArchitecture}");
        Console.WriteLine($"Process Architecture: {RuntimeInformation.ProcessArchitecture}");
        Console.WriteLine($".NET Version: {RuntimeInformation.FrameworkDescription}");
    }
}