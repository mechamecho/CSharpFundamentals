﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //var array = new char[name.Length];
            //for (var i = name.Length; i > 0; i--)

            //    array[name.Length - i] = name[i - 1];

            //var reversed = new string(array);

            //Console.WriteLine("Reversed name: "+reversed);

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: "+reversed);

            /*var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number(or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            var uniques= new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var number in uniques)
            {
                Console.WriteLine(number);
            }*/

            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number(or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var number in GetUniqueNumbers(numbers))
            {
                Console.WriteLine(number);
            }


        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)

                array[name.Length - i] = name[i - 1];

            return new string(array);
            
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            return uniques;
        }
    }
}
