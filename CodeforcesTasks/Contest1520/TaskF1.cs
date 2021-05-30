using System;

namespace CodeforcesTasks.Contest1520
{
    public class TaskF1
    {
        static void Main(string[] args)
        {
            var right = int.Parse(Console.ReadLine()!.Split(' ')[0]);
            var zeroNo = int.Parse(Console.ReadLine()!);
            var left = 1;
            
            while (left < right)
            {
                var middle = (left + right) / 2;
                Console.WriteLine($"? {left} {middle}");
                var elementSum = int.Parse(Console.ReadLine()!);
                if (elementSum == -1) return;

                var zeros = middle + 1 - left - elementSum;
                if (zeros >= zeroNo)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                    zeroNo -= zeros;
                }
            }

            Console.WriteLine($"! {left}");
        }
    }
}