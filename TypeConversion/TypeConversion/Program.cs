using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            byte b = 1;
            int i = b;

            Console.WriteLine(i);

            //explicit conversion
            i = 1;
            b = (byte) i;
            Console.WriteLine(b);

            i = 1000;
            b = (byte) i;
            //output 232 because only 1 byte is available for storage
            Console.WriteLine(b);

            //incompatible types
            var number = "1234";
            i = Convert.ToInt32(number);
            Console.WriteLine(i);
            try
            {
                number = "1234";
                b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            //Strings are not compatible with booleans 
            //naming variables with letters is not good practice, it is better to use descriptive names
            try
            {
                string str = "true";
                bool bo= Convert.ToBoolean(str);
                Console.WriteLine(bo);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }







        }
    }
}
