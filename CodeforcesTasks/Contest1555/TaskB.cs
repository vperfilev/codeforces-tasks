using System;
using System.Text.RegularExpressions;

namespace CodeforcesTasks.Contest1555
{
    public class TaskB
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var a = Read();
                var b = Read();
                var c = Read();
                Console.WriteLine(Solve((a[0], a[1]), (b[0], b[1]), (b[2], b[3]), (c[0], c[1])));
            }
        }
        
        public static int Solve((int w, int h) roomSize, (int x, int y) tableCorner1, (int x, int y) tableCorner2,
            (int w, int h) tableBSize)
        {
            var tableASize = (w: tableCorner2.x - tableCorner1.x, h: tableCorner2.y - tableCorner1.y);
            var wPossible = tableBSize.w + tableASize.w <= roomSize.w;
            var hPossible = tableBSize.h + tableASize.h <= roomSize.h;
            if (!wPossible && !hPossible) return -1;

            var distance = int.MaxValue;
            if (wPossible)
            {
                var biggestSize = Math.Max(tableCorner1.x, roomSize.w - tableCorner2.x);
                distance = tableBSize.w - biggestSize;
            }

            if (hPossible)
            {
                var biggestSize = Math.Max(tableCorner1.y, roomSize.h - tableCorner2.y);
                distance = Math.Min(distance, tableBSize.h - biggestSize);
            }

            return distance < 0 ? 0 : distance;
        }
    }
}