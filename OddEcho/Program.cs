using System;

namespace OddEcho
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {
                var word = Console.ReadLine();

                if (i % 2 != 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}