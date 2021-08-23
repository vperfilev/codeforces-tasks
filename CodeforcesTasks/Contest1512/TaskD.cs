using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1512
{
    public class TaskD
    {
        static long[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < n; i++)
            {
                Console.ReadLine();
                Console.WriteLine(string.Join(' ', Solve(Read())));
            }
        }

        public static long[] Solve(long[] bArray)
        {
            var bSum = bArray.Sum();
            Array.Sort(bArray);
            
            for (var i = bArray.Length - 2; i < bArray.Length; i++)
            {
                var b = bArray[i];
                var x = bSum - 2 * b;
                if (x < 0) continue;
                var xIndex = Array.BinarySearch(bArray, x);
                var bIndex = Array.BinarySearch(bArray, b);
                if (xIndex < 0 || bIndex < 0) continue;
                if (bIndex == xIndex && bArray.Count(x => x ==b) < 2) continue;
                        
                var itemsToRemove = new List<long>(new[] { b, x });
                var aArray = new long[bArray.Length - 2];
                var aIndex = 0;
                
                foreach (var bValue in bArray)
                {
                    if (itemsToRemove.Contains(bValue))
                        itemsToRemove.Remove(bValue);
                    else
                        aArray[aIndex++] = bValue;
                }
                return aArray;
            }

            return new long[]{-1};
        }
    }
}