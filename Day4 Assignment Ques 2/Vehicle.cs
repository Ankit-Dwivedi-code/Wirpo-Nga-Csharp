using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assignment
{
    internal class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting generic vehicle engine...");
        }
    }

    internal class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started with a keyless push button.");
        }
    }

    // Derived class 2
    internal class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started with a kick start.");
        }
    }

    // Derived class 3
    internal class Truck : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Truck engine started with a heavy-duty ignition.");
        }
    }
}
