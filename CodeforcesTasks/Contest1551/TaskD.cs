using System;

namespace CodeforcesTasks.Contest1551
{
    // https://codeforces.com/contest/1551/problem/D1
    public class TaskD
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var p = Read();
                Console.WriteLine(Solve(p[0], p[1], p[2]) ? "YES" : "NO");
            }
        }
        
        public static bool Solve(int n, int m, int k)
        {
            if (n % 2 == 0 && m % 2 == 0)
            {
                return k % 2 == 0;
            }

            if (n % 2 == 0)
            {
                var maxHorizontal = n * (m / 2);
                return k <= maxHorizontal && k % 2 == 0;
            }

            var horizontalSize = m / 2;
            return k >= horizontalSize && Solve(n - 1, m, k - horizontalSize);
        }
    }
    
    // https://codeforces.com/contest/1551/problem/D1
}