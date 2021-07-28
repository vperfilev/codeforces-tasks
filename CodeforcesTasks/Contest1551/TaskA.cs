using System;

namespace CodeforcesTasks.Contest1551
{
    // https://codeforces.com/contest/1551/problem/A
    public class TaskA
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var (oneCount, twoCount) = Solve(int.Parse(Console.ReadLine()!));
                Console.WriteLine($"{oneCount} {twoCount}");
            }
        }
        public static (int oneCount, int twoCount) Solve(int amount)
        {
            var oneCount = (amount) / 3;
            var twoCount = oneCount;
            if (amount % 3 == 1) oneCount++;
            else if (amount % 3 == 2) twoCount++;
            return (oneCount, twoCount);
        }
    }
}