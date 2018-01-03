using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void Exercise1()
        {
            //Exercise 1

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Exercise2()
        {
            //Exercise 2:
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    var num = int.Parse(input);
                    sum += num;
                    continue;

                }
                break;

            }
            Console.WriteLine(sum);
        }

        public void Exercise3()
        {
            //Exercise 3
            Console.WriteLine("Please enter a number");
            var number = int.Parse(Console.ReadLine());
            var factorial = 1;
            for (var i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }

        public void Exercise4()
        {
            //Exercise 4
            Console.WriteLine("Please guess the winning number in range 1-10");
            var random= new Random();
            var winningNumber= random.Next(1, 10);
            for (var i = 1; i <= 4; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (input == winningNumber)
                {
                    Console.WriteLine($"You won! The winning number was {winningNumber}");
                    break;
                }else if (i == 4)
                {
                    Console.WriteLine($"Sorry! You lost :( The winning number was {winningNumber}");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
        }

        public void Exercise5()
        {
            var max = int.MinValue;
            while (true)
            {
                Console.WriteLine("Please enter some numbers.");
                var input = Console.ReadLine();
                var numArray = input.Split(',');
                foreach (var numberString in numArray)
                {
                    var currNum = int.Parse(numberString);
                    if (currNum > max)
                    {
                        max = currNum;
                    }
                }
                Console.WriteLine("The max number in this group of numbers is " + max);


            }
        }

    }
}
