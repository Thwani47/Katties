using System;

namespace FizzBuz
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var x = int.Parse(input[0]);
            var y = int.Parse(input[1]);
            var n = int.Parse(input[2]);
            
            for(var i = 1; i <= n; i++)
            {
                PrintFizzBuzz(i, x, y);
            }
        }

        static void PrintFizzBuzz(int i, int x, int y)
        {
            if ((i % x == 0) && (i % y  == 0)) Console.WriteLine("FizzBuzz");
            else if (i % y == 0) Console.WriteLine("Buzz");
            else if (i %x == 0) Console.WriteLine("Fizz");
            else Console.WriteLine(i);
        }
    }
}
