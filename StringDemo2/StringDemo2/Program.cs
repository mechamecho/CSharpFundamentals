using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Nafissa Hassan ";
            Console.WriteLine($"Trim:'{fullName.Trim()}' ");
            Console.WriteLine($"Trim:'{fullName.Trim().ToUpper()}' ");

            var index = fullName.IndexOf(" ");
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);

            Console.WriteLine("First Name: "+firstName);
            Console.WriteLine("Last Name: "+lastName);

            var names=fullName.Split(' ');
            Console.WriteLine("First Name: "+names[0]);
            Console.WriteLine("Last Name: "+ names[1]);

            var newfullName=fullName.Replace("Nafissa", "Luli");
            Console.WriteLine("New full name: "+ newfullName);

            if (String.IsNullOrEmpty(" "))
            {
                Console.WriteLine("Invalid.");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine("Converted Number "+age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));


        }
    }
}
