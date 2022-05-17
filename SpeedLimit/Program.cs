using System;
using System.Collections.Generic;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (!input.Equals("-1"))
            {
                var n = int.Parse(input);
                var log = new List<KeyValuePair<int, int>>();
                for(var i = 0; i < n; i++)
                {
                    var inputPair = Console.ReadLine().Split(' ');
                    var pair = new KeyValuePair<int, int>(int.Parse(inputPair[1]), int.Parse(inputPair[0]));
                    log.Add(pair);
                }
                PrintDistance(log);
                input = Console.ReadLine();
            }
        }

        private static void PrintDistance(List<KeyValuePair<int, int>> log)
        {
            var totalDistance = 0;
            var adjustedTimes = new int[log.Count];
            adjustedTimes[0] = log[0].Key;
            for(var i = 1; i < log.Count;i++)
            {
                adjustedTimes[i] = log[i].Key - log[i - 1].Key;
            }
            
            for(var i = 0; i < log.Count; i++)
            {
                totalDistance += adjustedTimes[i]*log[i].Value;
            }
            Console.WriteLine($"{totalDistance} miles");
        }
    }
}
