using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesSection8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exercise5());
            
        }

        static string Exercise1()
        {
            Console.WriteLine("Please enter a few numbers seperated by a hyphen");
            var input = Console.ReadLine();
            var numbers = input.Split('-');
            var isConsecutive = true;
            for (var i = 0; i < numbers.Length-1; i++)
            {
                var currentNumber = Convert.ToInt32(numbers[i]);
                var nextNumber = Convert.ToInt32(numbers[i + 1]);
                var difference = Math.Abs((currentNumber - nextNumber));
                if (difference != 1)
                {
                    isConsecutive = false;
                }
            }

            if (isConsecutive)
            {
                return "Consecutive";
            }
            return "Not Consecutive";
        }

        public static string Exercise2()
        {
            Console.WriteLine("Please enter a few numbers seperated by a hyphen");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                return "Invalid Input";
            }
            var numberStrings = input.Split('-');
            var hasDuplicates = false;
            var numbers = new List<int>();
            foreach (var numberString in numberStrings)
            {
                
                if (numbers.Contains(Convert.ToInt32(numberString)))
                {
                    hasDuplicates = true;
                    return "Duplicate";
                }
                numbers.Add(Convert.ToInt32(numberString));


            }
            return "Contains only unique values";
        }

        public static string Exercise3()
        {
            Console.WriteLine("Please type in a time in the 24 time format");
            var input = Console.ReadLine();
            var inputSplit = input.Split(':');
            var timeList = new List<int>();
            
            foreach (var number in inputSplit)
            {
             timeList.Add(Convert.ToInt32(number));   
            }
            var isInCorrectFormat = true;
            if (inputSplit[0].Length > 2 || inputSplit[1].Length > 2)
            {
                return "Invalid";
            }
            if (!(timeList[0] < 24 && timeList[0] >= 0)||!(timeList[1]<60||timeList[1]>=0))
            {
                return "Invalid";
            }
            return "Ok";
        }

        public static string Exercise4()
        {
            Console.WriteLine("Please enter words seperated by spaces");
            var camelCaseString = "";
            var input = Console.ReadLine().Split(' ');
            foreach (var word in input)
            {
                camelCaseString += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            }
            return camelCaseString;
        }

        public static int Exercise5()
        {
            Console.WriteLine("Please enter a word");
            var input = Console.ReadLine().ToLower();
            var vowels = new List<Char>() {'a', 'e', 'o', 'u', 'i'};
            var counter = 0;
            foreach (var character in input)
            {

                if (vowels.Contains(character))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
