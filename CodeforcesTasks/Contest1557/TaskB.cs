using System;
using System.Linq;

namespace CodeforcesTasks.Contest1557
{
    public class TaskB
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var p = Read();
                Console.WriteLine(Solve(Read(), p[1]) ? "YES" : "NO");
            }
        }
        
        public static bool Solve(int[] numbers, int k)
        {
            var positions = Enumerable.Range(1, numbers.Length).ToArray();
            Array.Sort(numbers, positions);
            var minSegments = 1;
            
            for (var i = 1; i < positions.Length; i++)
            {
                if (positions[i-1] + 1 != positions[i]) minSegments++;
            }

            return minSegments <= k && k <= numbers.Length;
        }
    }
}