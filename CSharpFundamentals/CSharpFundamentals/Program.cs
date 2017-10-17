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
            var nafissa= new Person();
            nafissa.FirstName = "Nafissa";
            nafissa.LastName = "Hassan";
            nafissa.Introduce();
            Calculator caclulator= new Calculator();
            var result= caclulator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
