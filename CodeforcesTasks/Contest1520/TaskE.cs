using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1520
{
    // https://codeforces.com/contest/1520/problem/E
    public class TaskE
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine()!);
            for (var testNo = 0; testNo < testCount; testNo++)
            {
                Console.ReadLine();
                Console.WriteLine(Solve(Console.ReadLine()));
            }
        }

        public static long Solve(string field) 
        {
            var sheepPositions = field.Select((c,i) => c=='*'? i: -1).Where(x=> x>=0).ToArray();	
            if(sheepPositions.Length <= 1) return 0;
            
            var shift = sheepPositions[sheepPositions.Length/2] - sheepPositions.Length/2;
            return sheepPositions.Select((t, i) => (long)Math.Abs(i + shift - t)).Sum();
        }

    }
}