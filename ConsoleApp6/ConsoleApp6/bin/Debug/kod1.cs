using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
			Process.Start(@"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe", @"/nologo C:\Users\adv1\source\repos\ConsoleApp6\ConsoleApp6\bin\Debug\kod2.cs");
			Thread.Sleep(3000);
			Process.Start("kod2.exe");
            //C:\Windows\Microsoft.NET\Framework64\v4.0.30319
        }
    }
}
