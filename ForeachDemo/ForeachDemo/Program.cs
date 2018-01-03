using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Nafissa Hassan";
            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            var numArray = new int[] {1, 2, 3, 4};
            foreach (var number in numArray)
            {
                Console.WriteLine(number);
            }
            
                
            
        }
    }
}
