using System;
using System.Linq;

namespace CodeforcesTasks.Contest1538
{
    // https://codeforces.com/contest/1538/problem/A
    public class TaskA
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
        
        public static int Solve(int count, int[] rocks)
        {
            var min = (value: int.MaxValue, position: -1);
            var max = (value: int.MinValue, position: -1);
            
            for (var i = 0; i < count; i++)
            {
                var rock = rocks[i];
                if (rock > max.value) max = (value: rock, position: i);
                if (rock < min.value) min = (value: rock, position: i);
            }

            var minLeft = min.position + 1;
            var minRight = count - min.position;
            var maxLeft = max.position + 1;
            var maxRight = count - max.position;
            
            return new[]
            {
                Math.Max(maxLeft, minLeft), Math.Max(maxRight, minRight),
                maxLeft + minRight, minLeft + maxRight
            }.Min();
        }
    }
}