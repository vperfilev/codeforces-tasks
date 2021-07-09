using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1541
{
    // https://codeforces.com/contest/1541/problem/B
    public class TaskB
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.ReadLine();
                Console.WriteLine(Solve(Read()));
            }
        }
        
        public static int Solve(int[] input)
        {
            var goodPairsCount = 0;
            var values = input.Select((val, pos) => new {val, pos = pos + 1})
                .OrderBy(v => v.val)
                .ToArray();
            
            for (var i = 0; i < values.Length-1; i++) 
            {
                var a = values[i];
                var max = 2 * values.Length / a.val;
                
                for (var j=i+1;	j < values.Length; j++)
                {
                    if (values[j].val > max) break;
                    var b = values[j];
                    if (a.pos + b.pos == a.val * b.val) goodPairsCount++;
                }
            }
	
            return goodPairsCount;
        }
    }
}