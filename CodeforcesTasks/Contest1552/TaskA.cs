using System;
using System.Linq;

namespace CodeforcesTasks.Contest1552
{
    // https://codeforces.com/contest/1552/problem/A
    public class TaskA
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.ReadLine();
                Console.WriteLine(Solve(Console.ReadLine()));
            }
        }
        
        public static int Solve(string line)
        {
            var sorted = line.OrderBy(x => x).ToArray();
            var result = line.Length;
            for (var i = 0; i < line.Length; i++)
                if (line[i] == sorted[i]) result--;

            return result;
        }
    }
}