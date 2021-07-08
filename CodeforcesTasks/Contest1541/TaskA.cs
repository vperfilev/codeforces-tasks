using System;
using System.Collections.Generic;

namespace CodeforcesTasks.Contest1541
{
    // https://codeforces.com/contest/1541/problem/A
    public class TaskA
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                Console.WriteLine(string.Join(" ", Solve(n)));
            }
        }
        
        public static IEnumerable<int> Solve(int n)
        {
            var number = 0;
            var remainder = 1;
            if (n % 2 == 1)
            {
                yield return 3;
                yield return 1;
                yield return 2;
                number = 3;
                remainder  = 0;
            }

            while (number++ < n)
            {
                if (number % 2 == remainder ) yield return number + 1;
                else yield return number - 1;
            }
        }
    }
}