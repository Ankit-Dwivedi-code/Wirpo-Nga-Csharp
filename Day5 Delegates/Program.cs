using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo__Delegates;

namespace Day5_Delegates
{
    // Step1: Define a delegate type
    public delegate void GreetUser(string name);
    //type safe function pointer
    internal class Program
    {
        static void Main(string[] args)
        {

            //A delgate is type hat hold a refernce to a method with a specific signature.method1 (int, char)
            // A delegate allows methods to be passed as parameers and invoked dynamically (at runtime)
            // Delegates are ideal for implementing event handling and callback mechanisms, ex button click events, timer events, etc. //Steps for implemting delgates in C#
            //Step 1: Define a delegate type ex syntax : delegate returnType DelegateName(parameterType parameterName);
            //Step 2: Create,ethods matching delgate signature
            //Step 3: Create an instance of the delegate and assign it to a method inside main()

            // Step 3: Create an instance of the delegate and assign it to methods
            //GreetUser greetEnglish = new GreetUser(Greetings.GreetInEnglish);
            //greetEnglish("Ankit");

            //GreetUser multiGreet = Greetings.GreetInEnglish;
            //multiGreet += Greetings.GreetInSpanish;
            //multiGreet += Greetings.GreetInFrench;

            //multiGreet("Ankit");











            Greetings newGreetings = new Greetings(); // Create an instance of the Greetings class
            GreetUser greetUser; // Step 3: Declare a delegate variable


            Console.WriteLine("Initially we are using class object to call method sayhello():");
            newGreetings.SayHello("Raj"); // Assign the SayHello method to the delegate

            Console.WriteLine(" Now we are pointing to the method using delgate refrence and invoking it ...!!");
            greetUser = newGreetings.SayHello; // Assign the SayHello method to the delegate variable
                                               //in above line we are assigning the method SayHello to the delegate variable greetUser just likea pointer to the function 
            greetUser("Raj"); // Invoke the delegate, which calls the SayHello method

            Console.WriteLine(" Using delegate refernce for invoking another mathod..!!!");
            greetUser = newGreetings.SayGoodbye; // Reassign the delegate to the SayGoodbye method
                                                 //in above line we are assigning the method SayGoodbye to the delegate variable greetUser just like a pointer to the function
            greetUser("Raj"); // Invoke the delegate, which calls the SayGoodbye method

            Console.WriteLine(" here is args demo based on multicasting delgate..!");
            Notifier notify_obj = new Notifier(); // Create an instance of the Notifier class

            Notify notifyuser_del = notify_obj.SendEmail; // Create a delegate instance and assign it to the SendEmail method
            notifyuser_del += notify_obj.SendSMS; // Add the SendSMS method to the delegate instance also which is called multicasting delegate
                                                  //+= operator is used to add methods to the delegate instance, allowing multiple methods to be called when the delegate is invoked.

            notifyuser_del("Hello, this is a notification!"); // Invoke the delegate, which calls both SendEmail and SendSMS methods ie Event hndling
        }
    }

    // Step 2: Create methods matching the delegate signature
    //public class Greetings
    //{
    //    public static void GreetInEnglish(string name)
    //    {
    //        Console.WriteLine($"Hello, {name}!");
    //    }
    //    public static void GreetInSpanish(string name)
    //    {
    //        Console.WriteLine($"Hola, {name}!");
    //    }
    //    public static void GreetInFrench(string name)
    //    {
    //        Console.WriteLine($"Bonjour, {name}!");
    //    }
    //}


    public class Greetings
    {
        //Step 2: Create methods matching delgate signature
        //we use delgate rfrence for calling below methods hence class object is not required to call these methods
        public void SayHello(string name)// Method that matches the delegate signature
        {
            Console.WriteLine($"Hello, {name}!");
        }
        public void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye, {name}!");
        }
    }
}
