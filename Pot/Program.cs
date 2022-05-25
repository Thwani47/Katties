using System;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = 0;

            for(var i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var power = int.Parse(input[input.Length - 1].ToString());
                var number = int.Parse(input.Substring(0, input.Length -1));

                x += (int)Math.Pow(number, power);
            }

            Console.WriteLine(x);
        }
    }
}
