using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1538
{
    // https://codeforces.com/contest/1538/problem/D
    public class TaskD
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var values = Read();
                Console.WriteLine(Solve(values[0], values[1], values[2]) ? "YES" : "NO");
            }
        }
        public static bool Solve(int a, int b, int steps)
        {
            var minSteps = 2;
            if (a == b) minSteps = 0;
            else if (a % b == 0 || b % a == 0) minSteps = 1;
            if (steps < minSteps) return false;

            var maxSteps = GetNumberOfPrimes(a) + GetNumberOfPrimes(b);
            return minSteps <= steps && steps <= maxSteps && steps == 1 && minSteps == 1 ||
                       minSteps <= steps && steps <= maxSteps && steps != 1;
        }

        private static int GetNumberOfPrimes(int value)
        {
            var result = 0;
            for (var p = 2; p * p <= value; p++)
            {
                if (value % p != 0) continue;
                while (value % p == 0)
                {
                    result++;
                    value /= p;
                }
            }
            if (value != 1) result++;
            return result;
        }
    }
}