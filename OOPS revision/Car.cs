using System;

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
        Console.WriteLine($"SuperCar: {Year} {Model} {Make} {Color}");
    }
}
