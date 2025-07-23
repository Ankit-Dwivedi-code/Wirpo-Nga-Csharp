using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assignment_Ques3
{
    internal class CustomError : Exception
    {
        // here we will define our custom error for file path not found
        public CustomError(string message) : base(message)
        {

        }
    }
}
