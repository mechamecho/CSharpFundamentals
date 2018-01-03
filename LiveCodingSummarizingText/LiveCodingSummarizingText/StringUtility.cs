using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSummarizingText
{
    public class StringUtility
    {

        public static string SummerizeText(string text, int maxLength = 20)
        {

            if (text.Length < 20)
            {
                return text;
            }

            var summary = "";
            var words = text.Split(' ');
            var totalCharacters = 0;
            var wordsOfSummery = new List<String>();
            foreach (var word in words)
            {
                wordsOfSummery.Add(word);
                //plus 1 for the white space
                totalCharacters += word.Length + 1;
                if (totalCharacters > 20)
                {
                    break;
                }
            }

            return String.Join(" ", wordsOfSummery) + "...";


        }
    }
}
