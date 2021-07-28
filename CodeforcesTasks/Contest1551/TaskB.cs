using System;
using System.Linq;

namespace CodeforcesTasks.Contest1551
{
    // https://codeforces.com/contest/1551/problem/B1
    public class TaskB1
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine(Solve(Console.ReadLine()));
            }
        }
        
        public static int Solve(string text)
        {
            var counts = new int[26];
            foreach (var letter in text)
            {
                counts[letter - 'a']++;
            }

            return counts.Sum(v => v > 2 ? 2 : v) / 2;
        }
    }
}