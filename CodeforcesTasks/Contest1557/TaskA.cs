using System;
using System.Linq;

namespace CodeforcesTasks.Contest1557
{
    public class TaskA
    {
        static long[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.ReadLine();
                Console.WriteLine(Solve(Read()));
            }
        }
        public static double Solve(long[] values)
        {
            var max = values.Max();
            var sum = values.Sum();
            return (sum - max) * 1.0 / (values.Length - 1) + max;
        }
    }
}