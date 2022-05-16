using System;

namespace Reserve
{
    public static class Reserve
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for(var i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            for(var i = n-1 ; i >= 0 ; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
