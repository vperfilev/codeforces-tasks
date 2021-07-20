using System;

namespace CodeforcesTasks.Contest1538
{
    // https://codeforces.com/contest/1538/problem/C
    public class TaskC
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var p = Read();
                Console.WriteLine(Solve(p[0], p[1], p[2], Read()));
            }
        }
        
        public static long Solve(int number, int l, int r, int[] items)
        {
            Array.Sort(items);
            return CountLessThan(r, items) - CountLessThan(l-1, items);
        }

        private static long CountLessThan(int pairSum, int[] items)
        {
            var l = 0;
            var r = items.Length - 1;
            var result = 0L;
            
            while (true)
            {
                var maxRight = pairSum - items[l];
                while (r > l && items[r] > maxRight) r--;
                if (r == l) break;
                result += r - l++;
            }

            return result;
        }
    }
}