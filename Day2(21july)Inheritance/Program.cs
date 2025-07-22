using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Steps for understading Inheritance in C# ");
            Console.WriteLine(" 1. Create a base class with some properties and methods.");//Vehicle class 
            Console.WriteLine(" 2. Crating a child class defining and reusing parent/base class fucntionality"); // Car class
            Console.WriteLine(" 3. Create a child class that overrides a method from the base class."); // SportsCar class
            Console.WriteLine(" 4. Create a child class that adds new functionality."); // ElectricCar class
            Console.WriteLine(" 5. Create a child class that uses the base class's constructor."); // Truck class

            //base class
            //Creating a child class object
            Car mycar = new Car
            {
                Brand = "Toyota",
                Model = "Fortuner",
                Speed = 120,
            };
            Console.WriteLine(mycar.ToString());// Using ToString method from Car class which has overridden the base class method
            mycar.start();// Calling the start method from Vehicle class
            mycar.Honk(); // Calling the honk method from Car class
            mycar.stop(); // Calling the stop method from Vehicle class


            //Creating a child class object
            SportsCar mySportsCar = new SportsCar
            {
                Brand = "Ferrari",
                Model = "488",
                Speed = 200,
                HorsePower = 660
            };
            Console.WriteLine(mySportsCar.ToString());
            // Using ToString method from Car class which has overridden the base class method

            mySportsCar.start(); // Calling the overridden start method from SportsCar class
            mySportsCar.Honk(); // Calling the honk method from Car class
            mySportsCar.stop(); // Calling the stop method from Vehicle class

            //Final Observation in above demo is as follow: 
            // 1. The base class Vehicle defines common properties and methods for all vehicles.( Providing common fucntionality)
            // 2. The Car class inherits from Vehicle and adds specific properties and methods for cars, such as NumberOfDoors and Honk.
            // 3. The SportsCar class inherits from Car and overrides the start method to provide specific functionality for sports cars.
            //Here Reusability is achieved by inheriting from the base class and extending its functionality in derived classes.
            //Runtime polymorphism is demonstrated by overriding the start method in the SportsCar class,
            //allowing it to provide a specific implementation while still being treated as a Vehicle.
            // Here We can implement fucntion Overloading by defining multiple methods with the
            // same name but different parameters in the derived classes.
        }
    }

    
    
}