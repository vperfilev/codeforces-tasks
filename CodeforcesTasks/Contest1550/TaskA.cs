using System;

namespace CodeforcesTasks.Contest1550
{
    // https://codeforces.com/contest/1550/problem/A
    public class TaskA
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine(Solve(int.Parse(Console.ReadLine()!)));
            }
        }
        
        public static int Solve(int s)
        {
            var arrayValue = 1;
            var result = 0;
            while (s > 0)
            {
                s -= arrayValue;
                arrayValue += 2;
                result++;
            }

            return result;
        }
    }
}