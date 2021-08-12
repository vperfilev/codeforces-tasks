using System;

namespace CodeforcesTasks.Contest1555
{
    public class TaskA
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var number = long.Parse(Console.ReadLine()!);
                Console.WriteLine(Solve(number));
            }
        }
        public static long Solve(long count)
        {
            long pieces = 0;
            if (count % 2 == 1) count++;
            
            if (count > 12)
            {
                pieces = count - 6 - count % 6;
                count -= pieces;
            }

            if (count < 6) count = 6;
            pieces += count;
            return pieces / 2 * 5;
        }
    }
}