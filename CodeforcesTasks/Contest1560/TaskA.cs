using System;

namespace CodeforcesTasks.Contest1560
{
    public class TaskA
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var p = int.Parse(Console.ReadLine()!);
                Console.WriteLine(Solve(p));
            }
        }

        private static int Solve(int n)
        {
            var number = 1;
            for (var i = 1; i < n; i++)
            {
                number++;
                while (number % 3 == 0 || number.ToString().EndsWith('3')) number++;
            }

            return number;
        }
    }
}