using System;
using System.IO;

namespace hahahaha
{
    class Program
    {
        static void Main(string[] args)
        {
 			Console.WriteLine(File.ReadAllText("file.txt"));
 			Console.ReadKey();
        }
    }
}