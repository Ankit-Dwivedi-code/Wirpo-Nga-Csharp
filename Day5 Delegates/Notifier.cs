using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__Delegates
{
    //cretaing a delegate type
    public delegate void Notify(string message);
    public class Notifier
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent with message: {message}");
        }
        public void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent with message: {message}");
        }
    }
}