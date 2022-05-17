using System;

namespace SodaSlurper
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var e = int.Parse(input[0]);
            var f = int.Parse(input[1]);
            var c = int.Parse(input[2]);
            CalculateSodasDrank(e,f, c);
        }

        private static void CalculateSodasDrank(int emptyBottles, int bottlesFound, int sodaCost)
        {
            var totalBottles = emptyBottles + bottlesFound;
            var sodasDrank = 0;
            while (totalBottles >= sodaCost)
            {
                totalBottles -= sodaCost;
                sodasDrank +=1;
                totalBottles+=1;   
            }
            Console.WriteLine(sodasDrank);
        }
    }
}
