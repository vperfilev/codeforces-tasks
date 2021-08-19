using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1512
{
    public class TaskB
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < n; i++)
            {
                var lineCount = int.Parse(Console.ReadLine()!);
                var lines = new string[lineCount];  
                for (var j = 0; j < lineCount; j++) lines[j] = Console.ReadLine();

                var result = Solve(lines);
                foreach (var t in result) Console.WriteLine(t);
            }
        }

        public static string[] Solve(string[] lines)
        {
            var field = lines.Select(x => x.ToArray()).ToArray();
            var existingPoints = new List<(int x, int y)>(2);
            for (var x = 0; x < field.Length; x++)
            {
                var line = field[x];
                for (var y = 0; y < line.Length; y++)
                {
                    if (line[y] == '*')
                    {
                        existingPoints.Add((x, y));
                    }
                }
            }

            var point1 = existingPoints[0];
            var point2 = existingPoints[1];
            var point3 = (x:point1.x, y:point2.y);
            var point4 = (x:point2.x, y:point1.y);

            if (point1.x == point2.x)
            {
                var diffX = point1.x == 0 ? 1 : 0;
                point3.x = diffX;
                point4.x = diffX;
            }

            if (point1.y == point2.y)
            {
                var diffY = point1.y == 0 ? 1 : 0;
                point4.y = diffY;
                point3.y = diffY;
            }

            field[point3.x][point3.y] = '*';
            field[point4.x][point4.y] = '*';

            return field.Select(x => new string(x)).ToArray();
        }
    }
}