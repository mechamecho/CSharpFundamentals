using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCodingSummarizingText;

namespace LiveCodingSummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This will be a very long long long long long long long sentence";
            Console.WriteLine(StringUtility.SummerizeText(sentence, 40));
        }



        }


    
}
