using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApp6
{
    class Program
    {
        static List<int> list = new List<int>() { 3, 45, 45, 6757, 0b10001001100011101011, 2234, 45432, 9, 0x4D2, 0b1101100010101010 };
        static void Main(string[] args)
        {
            while (true)
            {
                Thread first = new Thread(new ThreadStart(First));
                Thread second = new Thread(new ThreadStart(Second));
                Thread third = new Thread(new ThreadStart(Third));
                first.Start();
                second.Start();
                third.Start();
                Thread.Sleep(1000);
                first.Abort();
                second.Abort();
                third.Abort();
            }

        }
        static void First()
        {
            list.Add(new Random().Next(0, 1000));
        }
        static void Second()
        {
            list.Sort();
            Console.Clear();
            Console.WriteLine("Min " + list[0]);
            Console.WriteLine("Middle " + list.Average());
            Console.WriteLine("Max " + list[list.Count - 1]);
        }
        static void Third()
        {
            list.Remove(list[new Random().Next(0, list.Count)]);
        }
    }
}