using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car(2020, "Toyota", "Camry", "Blue");
            //SuperCar car2 = new SuperCar(2019, "Honda", "Civic", "Red");
            //car2.display();

            //Console.ReadLine();


            //Car.RaceStart();
            //Console.WriteLine("There are {0} cars", Car.countCars);
            //car1.Start();
            //car1.DisplayInfo();
            //car2.Start();
            //car2.DisplayInfo();

            //car1.Stop();
            //car2.Stop();

            //Console.WriteLine(CalcAvg.Average(2, 5));
            //Console.WriteLine(Math.Sqrt(16));


        }
    }

    //class Car
    //{
    //    public string Make { get; set; }
    //    public string Model { get; set; }
    //    public int Year { get; set; }
    //    public string Color { get; set; }

    //    public static int countCars;
    //    public Car(string make, string model, int year, string color)
    //    {
    //        Make = make;
    //        Model = model;
    //        Year = year;
    //        Color = color;
    //        countCars += 1;
    //    }
    //    public void Start()
    //    {
    //        Console.WriteLine("{0} Car started.", Model);
    //    }
    //    public void Stop()
    //    {
    //        Console.WriteLine("Car stopped.");
    //    }

    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Color: {Color}");
    //    }

    //    public static void RaceStart()
    //    {
    //        Console.WriteLine("Race has been started");
    //    }

    //}

    // static class CalcAvg{
    //    public static int num1; 
    //    public static int num2;

    //    //public CalcAvg(int a, int b) It will give error
    //    //{
    //    //    num1 = a;
    //    //    num2 = b;
    //    //}

    //    public static double Average(int num1, int num2)
    //    {
    //        return (num1 + num2) / 2.0;
    //    }
    //}

    public class Car
    {
        protected int year;
        protected string make;
        protected string model;
        protected string color;


        public Car(int year, string make, string model, string color)
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.color = color;
        }
        public int getYear() { return year; }

    }

    public class SuperCar : Car
    {
        public SuperCar(int year, string make, string model, string color) : base(year, make, model, color) { }
        public void display()
        {
            Console.WriteLine($"SuperCar: {year} {model} {make} {color}");
        }
    }


}
