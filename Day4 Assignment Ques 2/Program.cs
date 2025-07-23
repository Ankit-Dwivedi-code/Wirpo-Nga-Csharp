using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle;
            vehicle = new Car();
            vehicle.StartEngine(); // Output: Car engine started with a keyless push button.
            vehicle = new Bike();
            vehicle.StartEngine(); // Output: Bike engine started with a kick start.
            vehicle = new Truck();
            vehicle.StartEngine(); // Output: Truck engine started with a heavy-duty ignition.
        }
    }
}
