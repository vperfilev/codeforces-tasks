using System;

namespace CodeforcesTasks.Contest1529
{
    public class TaskA
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < testCount; i++)
            {
                Console.ReadLine();
                var array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                var minValue = int.MaxValue;
                var minValueCount = 0;
                foreach (var value in array)
                {
                    if (value > minValue) continue;
                    if (value == minValue)
                    {
                        minValueCount++;
                    }
                    else
                    {
                        minValueCount = 1;
                        minValue = value;
                    }
                }

                Console.WriteLine(array.Length - minValueCount);
            }
        }
    }
}