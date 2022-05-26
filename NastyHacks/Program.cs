using System;

namespace NastyHacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for(var i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var r = int.Parse(input[0]);
                var e = int.Parse(input[1]);
                var c = int.Parse(input[2]);

                if (r > (e - c))
                {
                    Console.WriteLine("do not advertise");
                }
                else if (r == (e - c))
                {
                    Console.WriteLine("does not matter");
                }
                else 
                {
                    Console.WriteLine("advertise");
                }
            }
        }
    }
}
