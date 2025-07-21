using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_21july_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jagged array in C#
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6, 7 };
            jaggedArray[2] = new int[] { 8, 9 };
            // Displaying the jagged array by iterating through each row
            Console.WriteLine("Jagged Array:");
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(", ", row));
            }
        }
    }
}
