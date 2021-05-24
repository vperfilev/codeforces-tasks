using System;

namespace CodeforcesTasks.Contest1521
{
    // https://codeforces.com/contest/1521/problem/A
    public class TaskA
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var numbers = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
                var (a, b) = (numbers[0], numbers[1]);
                Console.WriteLine(b == 1 ? "NO" : $"YES {a} {a * b} {a * (b + 1)}");
            }

        }
    }
}