using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise5();
        }

        public static void Exercise1()
        {
            var nameList=new List<string>();
            while (true)
            {
                Console.WriteLine("Please type in a name: ");
                var name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    nameList.Add(name);
                    continue;
                }
                break;
            }
            var likes = nameList.Count;
            switch (likes)
            {
                case 0:
                    Console.WriteLine("0 likes :(");
                    break;
                case 1:
                    Console.WriteLine($"{nameList[0]} liked your Post.");
                    break;
                case 2:
                    Console.WriteLine($"{nameList[0]} and {nameList[1]} liked your Post.");
                    break;
                default:
                    Console.WriteLine($"{nameList[0]}, {nameList[1]} and {nameList.Count - 2} others liked it!");
                    break;
            }

        }

        public static void Exercise2()
        {
            Console.WriteLine("Please enter a name: ");
            var name = Console.ReadLine();
            var nameArray = new Char[name.Length];
            for (var i = 0; i < name.Length; i++)
            {
                nameArray[i] = name[i];
            }

            Array.Reverse(nameArray);
            foreach (var character in nameArray)
            {
                Console.WriteLine(character);   
            }
        }

        public static void Exercise3()
        {
            var uniqueNumbers= new List<int>();
            while (true)
            {
                Console.WriteLine("Please enter 5 unique numbers: ");
                var input = int.Parse(Console.ReadLine());
                if (uniqueNumbers.Contains(input))
                {
                    Console.WriteLine("This number was already entered, please try again");
                    continue;
                }

                uniqueNumbers.Add(input);
                if (uniqueNumbers.Count == 5)
                {
                    Console.WriteLine();
                    break;
                }

            }

            uniqueNumbers.Sort();
            foreach (var uniqueNumber in uniqueNumbers)
            {
                Console.WriteLine(uniqueNumber);
            }
        }

        public static void Exercise4()
        {   
            var numbersList= new List<int>();
            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                string input = Console.ReadLine();
                if (String.Compare("Quit", input)==0||String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                numbersList.Add(int.Parse(input));
            }
            var uniqueNumbers= new List<int>();
            foreach (var number in numbersList)
            {
                if (!uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                }
            }

            foreach (var uniqueNumber in uniqueNumbers)
            {
                Console.WriteLine(uniqueNumber);
            }
        }

        public static void Exercise5()
        {
            var numberList= new List<int>();
            Console.WriteLine("Please type in a list of 5 numbers seperated by comas: ");
            while (true)
            {
                var input = Console.ReadLine();
                var inputArray = input.Split(',');
                if (inputArray.Length == 5)
                {
                    foreach (var stringNumber in inputArray)
                    {
                        numberList.Add(int.Parse(stringNumber));
                    }
                    break;
                }
                Console.WriteLine("Invalid List, please retry!");
            }
            
            numberList.Sort();
            Console.WriteLine($"The 3 smallest number in the list are {numberList[0]}, {numberList[1]} and {numberList[2]}");
            
           

            

        }
    }
}
