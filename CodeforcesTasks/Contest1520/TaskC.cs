using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace CodeforcesTasks.Contest1520
{
    // https://codeforces.com/contest/1520/problem/C
    public class TaskC
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine()!);
            for (var testNo = 0; testNo < testCount; testNo++)
            {
                var size = int.Parse(Console.ReadLine()!);
                var result = FindSolution(size);
                foreach (var line in result)
                {
                    Console.WriteLine(string.Join(' ', line));
                }
            }
        }
        
        public static IEnumerable<int[]> FindSolution(int size)
        {
            if (size == 1) return new[] { new[] { 1 }};
            if (size == 2) return new[] { new[] { -1 }};
            
            var result = new int[size * size];
            var number = 0;
            for (var i = 0; i < result.Length; i+=2) result[i] = ++number;
            for (var i = 1; i < result.Length; i+=2) result[i] = ++number;
            return Enumerable.Range(0, size).Select(n => result[(n*size) .. ((n+1)*size)]);
        }
    }
}