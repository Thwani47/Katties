using System;
using System.Linq;

namespace Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10];
            for(var i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()) % 42;
            }

            Console.WriteLine(numbers.ToHashSet<int>().Count);
        }
    }
}
