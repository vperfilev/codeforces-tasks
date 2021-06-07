using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1520
{
    public class TaskD
    {
        // https://codeforces.com/contest/1520/problem/D
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine()!);
            for (var testNo = 0; testNo < testCount; testNo++)
            {
                Console.ReadLine();
                Console.WriteLine(FindSolution(Read()));
            }
        }

        public static long FindSolution(int[] numbers)
        {
            var groups = new Dictionary<int,int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                var group = numbers[i] - i;
                if (!groups.TryAdd(group, 1))
                    groups[group]++;
            }

            return groups.Where(x => x.Value > 1)
                .Select(x => x.Value)
                .Aggregate<int, long>(0, (current, inGroupCount) 
                    => current + (long)inGroupCount * (inGroupCount - 1) / 2);
        }
    }
}