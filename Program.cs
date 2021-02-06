using System;
using Components.Addition;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 10;
            int res = Addition.Add(a, b);
            Console.WriteLine(res);
        }
    }
}
