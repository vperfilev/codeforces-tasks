using System;

namespace CodeforcesTasks.Contest1527
{
    public class TaskA
    {
        // https://codeforces.com/contest/1527/problem/A
        static void Main(string[] args)
        {
            var testNumber = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < testNumber; i++)
            {
                var number = long.Parse(Console.ReadLine()!);

                long result = 0;
                
                while (number > 1)
                    result |= (number >>= 1);
                
                Console.WriteLine(result);
            }
        }
    }
}