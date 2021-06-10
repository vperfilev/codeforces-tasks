using System;

namespace CodeforcesTasks.Contest1526
{
    // https://codeforces.com/contest/1526/problem/B
    public class TaskBv2
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine()!);
                Console.WriteLine(number % 11 <= number / 111 ? "YES" : "NO");
            }
        }
    }
}