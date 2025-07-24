using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OperatorOverlaoding
{
    internal class MyClass
    {
        private string _name;// here i aking name of the class MyClass
        public MyClass(string name) // creating constrcutor
        {
            _name = name;
        }

        // Overloading the + operator
        public static MyClass operator +(MyClass a, MyClass b)//here we are overaloding the + operator to join two strings
        {
            // Concatenating the names of the two MyClass instances
            //here reurntype is MyClass and we are returning a new instance of MyClass with the concatenated name
            return new MyClass(a._name + " " + b._name);//here we are concatenating two string 
        }
        //overloading == operator
        public static bool operator ==(MyClass a, MyClass b) // here we are overloading the == operator to compare two strings
        {
            // Checking if the names of the two MyClass instances are equal
            //here return types is bool and we are returning true if both strings are equal or false if they are not equal
            return a._name == b._name; //here we are checking if both strings are equal
        }
        //overloading != operator
        public static bool operator !=(MyClass a, MyClass b) // here we are overloading the != operator to compare two strings
        {
            // Checking if the names of the two MyClass instances are not equal
            //here return types is bool and we are returning true if both strings are not equal or false if they are equal

            return a._name != b._name; //here we are checking if both strings are not equal
        }
        // Overriding the ToString method to return the name of the MyClass instance
        public override string ToString() // here we are overriding the ToString method to return the name of the MyClass instance without using the abstract keyword
        {
            return _name; //here we are returning the name of the MyClass instance
            //objective of overriding ToString method is to provide a string representation of the MyClass instance without invoking ToString method explicitly
        }
        // Overriding the Equals method to compare two MyClass instances
        public override bool Equals(object obj) // here we are overriding the Equals method to compare two MyClass instances
        {
            if (obj is MyClass other) // checking if the object is of type MyClass
            {
                return _name == other._name; //here we are checking if both strings are equal
            }
            return false; //if the object is not of type MyClass, we return false
        }
        // Overriding the GetHashCode method to return the hash code of the name of the MyClass instance
        public override int GetHashCode() // here we are overriding the GetHashCode method to return the hash code of the name of the MyClass instance
        {
            return _name.GetHashCode(); //here we are returning the hash code of the name of the MyClass instance
        }
        public static MyClass CreateInstance(string name) // here we are creating a static method to create an instance of MyClass
        {
            return new MyClass(name); //here we are returning a new instance of MyClass with the given name
        }

        //While creating an Abstract Method here in overlaoding the + operator, we are not using the abstract keyword because we are not creating an abstract class.


    }
}