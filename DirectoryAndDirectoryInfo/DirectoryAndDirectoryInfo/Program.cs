using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\users\Engineer\Desktop\CSharpFundamentals\newDirectory");
            var files= Directory.GetFiles(@"c:\users\Engineer\Desktop\CSharpFundementals", "*.sln", SearchOption.AllDirectories);
            foreach(var file in files)
            {
                //Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\users\Engineer\Desktop\CSharpFundementals", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }

            var directoryInfo = new DirectoryInfo(@"...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
