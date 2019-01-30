using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("Line1 - Value of c is " + c);
            c = a - b;
            Console.WriteLine("Line2 - Value of c is " + c);
            c = a * b;
            Console.WriteLine("Line3 - Value of c is " + c);
            c = a / b;
            Console.WriteLine("Line4 - Value of c is " + c);
            c = a % b;
            Console.WriteLine("Line5 - Value of c is " + c);
            c = a ++;
            Console.WriteLine("Line6 - Value of c is " + c);
            c = a --;
            Console.WriteLine("Line7 - Value of c is " + c);

            Console.ReadLine();

        }
    }
}
