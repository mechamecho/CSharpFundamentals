using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesSection9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path of the file whose number of words you want to count");
            var path = Console.ReadLine();
            Console.WriteLine(Exercise2(path));

        }

        public static int Exercise1(string path)
        {
            var fileInfo = new FileInfo(path);
            var text=File.ReadAllText(path);
            var linesOfText = text.Split('\n');
            var wordCounter = 0;
            foreach(var line in linesOfText)
            {
                var currentLineWords = line.Split(' ');
                wordCounter += currentLineWords.Length;
            }
            return wordCounter;
        }

        public static string Exercise2(string path)
        {
            var fileInfo = new FileInfo(path);
            var text = File.ReadAllText(path);
            var linesOfText = text.Split('\n');
            var longestWord = "";
            foreach (var line in linesOfText)
            {
                var currentLineWords = line.Split(' ');
                foreach(var word in currentLineWords)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
            }
            return longestWord;
        }
    }
}
