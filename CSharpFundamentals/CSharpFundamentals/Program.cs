using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFundamentals.Math;


namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var nafissa= new Person();
            nafissa.FirstName = "Nafissa";
            nafissa.LastName = "Hassan";
            nafissa.Introduce();
            Calculator caclulator= new Calculator();
            var result= caclulator.Add(1, 2);
            Console.WriteLine(result);*/

            var numbers = new int [3];
            numbers[0] = 1;


            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Nafissa", "Hind", "Louis"};
            Console.WriteLine(names [0]);

        }
    }
}
