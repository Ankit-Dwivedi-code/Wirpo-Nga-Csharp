using System;




namespace Day3_22july_Abstract_instances { 

    abstract class Payment
//an abstract class is a class that cannot create an instance of itself and it should have at least one abstract method
{
    //defining class memebers like properties and methods specially one absract method 1 reference
    public string PaymentId { get; set; }

    public abstract void MakePayment(decimal amount);
    //here we are not defining the body of the method
    //This is an abstract method that must be implemented by derived classes

    public void GenrateReceipt()
    {
        //This is a concrete method that can be used by derived classes
        Console.WriteLine($"Receipt generated for payment ID: {PaymentId}");
    }
}
}
