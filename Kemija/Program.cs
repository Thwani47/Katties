using System;
using System.Text.RegularExpressions;

namespace Kemija
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regEx = new Regex(@"p[aeiou]{1}", RegexOptions.IgnoreCase);

            input = Regex.Replace(input, @"apa", "a");
            input = Regex.Replace(input, @"epe", "e");
            input = Regex.Replace(input, @"ipi", "i");
            input = Regex.Replace(input, @"opo", "o");
            input = Regex.Replace(input, @"upu", "u");
            Console.WriteLine(input);
        }

    }
}