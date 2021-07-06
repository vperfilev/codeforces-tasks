using System;
using System.Linq;

namespace CodeforcesTasks.Contest1542
{
    public class TaskA
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.ReadLine();
                Console.WriteLine(Solve(Read()) ? "YES" : "NO");
            }
        }

        public static bool Solve(int[] values) => 
            values.Length == 2 * values.Count(value => value % 2 == 0);
    }
}