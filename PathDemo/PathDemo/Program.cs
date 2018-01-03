using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Engineer\Desktop\CSharpFundementals\HelloWorld.sln";
            var extension = Path.GetExtension(path);
            Console.WriteLine("Extension: "+ extension);
            Console.WriteLine("File Name: "+ Path.GetFileName(path));
            Console.WriteLine("File Name without extension: "+ Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: "+ Path.GetDirectoryName(path));


        }
    }
}
