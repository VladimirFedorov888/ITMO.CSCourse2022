using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.HelloMyName
{
    internal class Greetings
    {
        static void Main(string[] args)
        {
            string myName;
            string mySurname;
            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Please enter your surname");
            mySurname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", myName, mySurname);

        }
    }
}