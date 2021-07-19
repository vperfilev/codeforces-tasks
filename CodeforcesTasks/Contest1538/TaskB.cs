using System;

namespace CodeforcesTasks.Contest1538
{
    // https://codeforces.com/contest/1538/problem/B
    public class TaskB
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                Console.WriteLine(Solve(n, Read()));
            }
        }
        
        public static int Solve(int n, int[] candies)
        {
            if (n == 1) return 0;
            
            var total = candies[0];
            var elementsAreEqual = true;
            for (var i = 1; i < n; i++)
            {
                elementsAreEqual &= candies[i] == candies[i - 1];
                total += candies[i];
            }

            if (elementsAreEqual) return 0;

            if (total % n != 0) return -1;

            var average = total / n;
            var result = 0;
            for (var i = 0; i < n; i++)
            {
                if (candies[i] > average) result++;
            }
            return result;
        }
    }
}