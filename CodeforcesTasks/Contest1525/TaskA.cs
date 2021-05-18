using System;

namespace CodeforcesTasks.Contest1525
{
    // https://codeforces.com/contest/1525/problem/A
    public class TaskA
    {
        static void Main(string[] args)
        {
            var testNumber = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < testNumber; i++)
            {
                var testData = Console.ReadLine();
                var result = FindSolution(int.Parse(testData!));
                Console.WriteLine(result);
            }
        }

        private static int FindSolution(int percent)
        {
            var (min, max) = percent < 50 ? (percent, 100 - percent) : (100 - percent, percent);
            if (min == 0) return 1;

            while (true)
            {
                var remainder = max % min;
                if (remainder == 0) break;
                (min, max) = min < remainder ? (min, remainder) : (remainder, min);
            }

            return 100 / min;
        }
    }
}