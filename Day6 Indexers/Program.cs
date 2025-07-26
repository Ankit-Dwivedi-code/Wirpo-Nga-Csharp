using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Indexers
{
    //Indexers are special properties that allow instances of a class or struct to be indexed like arrays.
    class BookShelf
    {
        private string[] books = new string[3];

        // Indexer declaration
        public string this[int index]
        {
            // Getter
            get
            {
                return books[index];
            }
            // Setter
            set
            {
                books[index] = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();

            // Assign values using the indexer
            shelf[0] = "C Programming";
            shelf[1] = "Data Structures";
            shelf[2] = "C# Basics";

            // Access values using the indexer
            Console.WriteLine("First book: " + shelf[0]);
            Console.WriteLine("Second book: " + shelf[1]);
            Console.WriteLine("Third book: " + shelf[2]);

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
