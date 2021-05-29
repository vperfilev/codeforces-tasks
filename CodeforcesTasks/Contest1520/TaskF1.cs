using System;

namespace CodeforcesTasks.Contest1520
{
    public class TaskF1
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine()!.Split(' ')[0]);
            var zeroNo = int.Parse(Console.ReadLine()!);
            Solve(size, zeroNo, 1);
        }

        private static void Solve(int size, int zeroNo, int offset)
        {
            if (size == 1)
            {
                Console.WriteLine($"! {offset}");
                return;
            }
            
            var middle = size / 2;
            Console.WriteLine($"? {offset} {offset + middle - 1}");
            var elementSum = int.Parse(Console.ReadLine()!);
            if (elementSum == -1)
                return;
            
            var zeros = middle - elementSum;
            if (zeros >= zeroNo)
                Solve(middle, zeroNo, offset);
            else
                Solve(size - middle, zeroNo - zeros, offset + middle);
        }
    }
}