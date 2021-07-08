using System;

namespace CodeforcesTasks.Contest1542
{
    // https://codeforces.com/contest/1542/problem/B
    public class TaskB
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var v = Read();
                Console.WriteLine(Solve(v[0],v[1], v[2]) ? "YES" : "NO");
            }
        }
        public static bool Solve(int number, int a, int b)
        {
            var smallest = 1L;
            while (smallest <= number)
            {
                if (smallest % b == number % b) return true;
                if (a == 1) return false;
                smallest *= a;
            }
            return false;
        }
    }
}