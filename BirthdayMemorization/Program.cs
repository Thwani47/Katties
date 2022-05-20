using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var birthdayData = new Dictionary<string, Dictionary<int, string>>();
            for (var i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                if (!birthdayData.ContainsKey(line[2]))
                {
                    birthdayData[line[2]] = new Dictionary<int, string>() { };
                }

                birthdayData[line[2]][int.Parse(line[1])] = line[0];
            }

            var friends = (from b in birthdayData let target = birthdayData[b.Key].Keys.Max() select birthdayData[b.Key][target]).ToList();
            friends.Sort();
            
            Console.WriteLine(friends.Count);
            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }
        }
    }
}