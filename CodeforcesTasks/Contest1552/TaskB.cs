using System;
using System.Linq;

namespace CodeforcesTasks.Contest1552
{
    // https://codeforces.com/contest/1552/problem/B
    public class TaskB
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var setCount = int.Parse(Console.ReadLine()!);
                var sets = new int[setCount][];
                for (var j = 0; j < setCount; j++)
                {
                    sets[j] = Read();
                }
                Console.WriteLine(Solve(sets));
            }
        }
        
        public static int Solve(int[][] positions)
        {
            var greatestPos = 0;
            var greatestValues = positions[0];
            
            for (var i = 1; i < positions.Length; i++)
            {
                if (!FirstIsGreater(positions[i], greatestValues)) continue;
                greatestValues = positions[i];
                greatestPos = i;
            }

            return positions.All(x => FirstIsGreater(greatestValues, x)) ? greatestPos + 1 : -1;
        }

        private static bool FirstIsGreater(int[] first, int[] second)
        {
            var firstWin = 0;
            for (var i = 0; i < 5; i++)
            {
                if (first[i] <= second[i]) firstWin++;
            }

            return firstWin >= 3;
        }
    }
}