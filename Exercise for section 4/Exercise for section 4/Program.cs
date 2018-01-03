using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_section_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Exercise 1:
            /*Console.WriteLine("Please enter a number!");
            var number = (int)int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }*/

            //Exercise 2:
            /*Console.WriteLine("Please enter two numbers!");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(string.Format("{0} > {1}", num1, num2));
            }else if (num2 > num1)
            {
                Console.WriteLine(string.Format("{0} > {1}", num2, num1));
            }
            else
            {
                Console.WriteLine(string.Format("{0} and {1} are equal",num1, num2));
            }*/

            //Exercise 3

            /*Console.WriteLine("Please enter the height of the image");
            var height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the image");
            var width = int.Parse(Console.ReadLine());

            var image = (height > width) ? "Portrait" : "Landscape";
            Console.WriteLine(image);
            */

            //Exercise 4:

            Console.WriteLine("Please enter the speed of the Car");
            var speed = int.Parse(Console.ReadLine());
            if (speed <= 30)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var exceeededLimitBy = (speed - 30) / 5;
                if (exceeededLimitBy > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine(string.Format("The demerit points are {0}", exceeededLimitBy));
                }

            }


        }

    }
}
