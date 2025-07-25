using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_File_handling_streams
{
    public class CustomExceptionForFile : Exception
    {
        public CustomExceptionForFile(string message) : base(message)
        {

        }
    }

    public class CustomExceptionForEmployee : Exception
    {
        public CustomExceptionForEmployee(string message) : base(message)
        {
        }
    }

}
