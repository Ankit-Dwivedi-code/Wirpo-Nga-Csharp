using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance
{
    public class Vehicle
    {
        public string Brand { get; set; }// Property to hold the brand of the vehicle
        public int Speed { get; set; } // Property to hold the speed of the vehicle
        public virtual void start()//Defingg a virtual method to be overridden in derived classes
        { Console.WriteLine($"{Brand} Vehicle is starting"); }

        public void stop()
        { Console.WriteLine($"{Brand} Vehicle is stopping"); }
    }

    public class Car : Vehicle // Car class inherits from Vehicle
    {
        public int NumberOfDoors { get; set; } // Property specific to Car
        public string Model { get; set; } // Property specific to Car
        public void Honk()
        {
            Console.WriteLine($"{Brand}  {Model} Car is honking : Beep Beep ... !!!");
        }

        //Overridig base class method
        public override string ToString()
        {
            return $"{Brand} {Model} Car with {NumberOfDoors} doors is moving at {Speed} km/h.";
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} {Model} Car engine is starting.");
        }

    }

    public class SportsCar : Car // SportsCar class inherits from Car
    {
        public int HorsePower { get; set; } // Property specific to SportsCar
        // Overriding the start method from Vehicle
        public override void start()
        {
            Console.WriteLine($"{Brand} {Model} SportsCar with {HorsePower} HP is roaring to life!");
        }
    }
}