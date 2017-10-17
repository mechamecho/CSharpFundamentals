using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a+b);
            Console.WriteLine(a/3);
            Console.WriteLine((float) a/(float) b);

            a = 1;
            b = 2;
            var c = 3;
            //division and multiplication have precedence to addition and substraction
            Console.WriteLine(a+b*c);

            // the result of comparison operators is always true, or false
            Console.WriteLine(!(a!=b)); //result should be false
            //same as
            Console.WriteLine(a==b);
            Console.WriteLine(c>b &&c>a);
            Console.WriteLine(c>b && c==a);
            Console.WriteLine(c>b|| c==a);



        }
    }
}
