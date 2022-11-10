using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    public class Test
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Main()
        {
            int x;
            int y;
            Console.Write("Enter first number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swap: " + x + "," + y);
            Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);
            Console.ReadKey();
        }
    }
}
