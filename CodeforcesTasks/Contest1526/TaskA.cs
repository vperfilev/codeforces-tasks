using System;

namespace CodeforcesTasks.Contest1526
{
    public class TaskA
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < count; i++)
            {
                Console.ReadLine();
                var result = Solve(Read());
                Console.WriteLine(string.Join(" ", result));
            }
        }
        
        public static int[] Solve(int[] numbers)
        {
            Array.Sort(numbers);
            var result = new int[numbers.Length];
            for(var i = 0; i < numbers.Length; i++)
            {
                result[i] = i % 2 == 0 ? numbers[i/2] : numbers[i/2 + numbers.Length/2];
            }
            return result;
        }
    }
}