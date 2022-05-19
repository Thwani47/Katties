using System;

namespace Skocimis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var a = int.Parse(input[0]);
            var b = int.Parse(input[1]);
            var c = int.Parse(input[2]);

            Console.WriteLine(Math.Max(b - a - 1, c - b - 1));
        }
    }
}