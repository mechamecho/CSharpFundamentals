using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i% 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}

            while (true)
            {
                Console.Write("Type your name");
                var input=Console.ReadLine();
                if (!String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                    break;
                
            }
        }
    }
}
