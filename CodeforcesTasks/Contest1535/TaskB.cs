using System;
using System.Linq;

namespace CodeforcesTasks.Contest1535
{
    
    // https://codeforces.com/contest/1535/problem/B
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
        
        public static int Solve(int[] values)
        {
            var size = values.Length;
            var odd = values.Where(v => v%2 == 1).ToArray();
            var oddCount = odd.Length;
            var evenCount = size - oddCount;
            var result = evenCount * (evenCount - 1) / 2 + evenCount * oddCount;
	
            for(var i = 0; i < oddCount; i++)
            {
                for(var j = i + 1; j < oddCount; j++)
                {
                    if (FindGcd(odd[i], odd[j]) > 1) result++;
                }
            }
            return result;
        }

        private static int FindGcd(int a, int b) 
        {
            (a,b) = a<=b ? (a,b) : (b,a);
            while (true)
            {
                var remainder = a % b;
                if (remainder == 0) break;
                (b, a) = b < remainder ? (b, remainder) : (remainder, b);
            }
            return b;
        }
    }
}