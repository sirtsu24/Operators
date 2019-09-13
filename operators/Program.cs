using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;

            //Arithmetic Operators
            //Multipe Line Comment
            /*Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y); */

            //Console.WriteLine(x = y);
            //Console.WriteLine(x += y);
            //Console.WriteLine(x -= y);
            //Console.WriteLine(x *= y);
            //Console.WriteLine(x % y);
            //Console.WriteLine(x /= y);

            //Comparison Operators
            /*Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x < y);
            Console.WriteLine(x <= y);*/

            //Logical Operators
            // && - AND 
            // || - OR (pipes)
            Console.WriteLine(x != y && y == 2);
            Console.WriteLine(x != y && y == 10);
            Console.WriteLine(x != y || y == 2);
            Console.WriteLine(!(y == 10));
            

            Console.ReadLine();
        }
    }
}
