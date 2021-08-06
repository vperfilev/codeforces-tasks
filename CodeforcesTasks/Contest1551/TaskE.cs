using System;

namespace CodeforcesTasks.Contest1551
{
    // https://codeforces.com/contest/1551/problem/E
    public class TaskE
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var initValues = Read();
                Console.WriteLine(Solve(Read(), initValues[1]));
            }
        }
        
        public static int Solve(int[] numbers, int goodItems)
        {
            var numbersLength = numbers.Length;
            var dp = new int[numbersLength + 1, numbersLength + 1];
            for (var i = 0; i < numbersLength; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    dp[i + 1, j] = Math.Max(dp[i + 1, j], dp[i, j]);
                    dp[i + 1, j + 1] = Math.Max(dp[i + 1, j + 1], dp[i, j] + (numbers[i] == j + 1 ? 1 : 0));
                }
            }
	
            var answer = -1;
            for (var i = numbersLength; i >= 0; i--)
            {
                if (dp[numbersLength, i] < goodItems) continue;
                answer = numbersLength - i;
                break;
            }

            return answer;
        }
    }
}