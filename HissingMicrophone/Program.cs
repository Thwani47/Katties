using System;

namespace HissingMicrophone
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input.Contains("ss"))
            {
                Console.WriteLine("hiss");
            }
            else 
            {
                Console.WriteLine("no hiss");
            }

        }
    }
}
