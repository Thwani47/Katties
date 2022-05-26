using System;
using System.Text;

namespace Greetings2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine($"{input[0]}{input.Substring(1, input.Length -2).Repeat(2)}{input[input.Length-1]}");
        }
    }
    //https://stackoverflow.com/questions/3754582/is-there-an-easy-way-to-return-a-string-repeated-x-number-of-times
    public static class StringExtensions
    {
        public static string Repeat(this string s, int n) => new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
    }
}