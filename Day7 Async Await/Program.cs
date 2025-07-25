using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Async_Await
{
    internal class Program
    //Non-Blocking execution using async and await
    //Parallel execution of tasks
    //Efficient resourse management
    //Overall performance improvement

    //Why we should use Task as compared to Thread/ThreadPool?
    // Task simplifies code using async and await keywords
    // It automatically capures execution
    //Better scability in async environments
    //It easier to combine, chain or cancel task
    //while ordering a pizza (a Task)....when pizza is done( So you awaited it).

    {
        static async Task Main(string[] args)  // async makes a method asynchronous
        {
            Console.WriteLine("Async and await methods... !!!");
            Console.WriteLine("Fetch student data ...!!!");
            // call async method
            string result = await FetchStudentDataAsync();  // await tells the compiler to wait for the task to complete before proceeding
            Console.WriteLine(result);
            Console.WriteLine("Process Completed...!!!");
        }

        static async Task<string> FetchStudentDataAsync()
        {
            await Task.Delay(2000); // Simulating a delay of 2 seconds and here Task represents an asynchronous operation
            return "Student data fetched successfully!";
        }
    }
}
