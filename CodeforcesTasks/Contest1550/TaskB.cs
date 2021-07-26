using System;
using System.Linq;

namespace CodeforcesTasks.Contest1550
{
    // https://codeforces.com/contest/1550/problem/B
    public class TaskB
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var values = Read();
                Console.WriteLine(Solve(values[0], values[1], values[2], Console.ReadLine()!));
            }
        }
        
        public static int Solve(int len, int a, int b, string line)
        {
            if (b >= 0) return len * (a + b);

            var last = line.First();
            var chunkCount = 1;
            for (var i = 1; i < len; i++)
            {
                if (line[i] == last) continue;
                last = line[i];
                chunkCount++;
            }

            return (chunkCount / 2 + 1) * b + len * a;
        }
    }
}