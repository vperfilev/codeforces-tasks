using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1520
{
    public class TaskG
    {
	    static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
	    
	    static void Main(string[] args)
	    {
		    var parameters = Read();
		    var (height, width, stepPrice) = (parameters[0], parameters[1], parameters[2]);
		    var field = new int [width, height];
		    for (var y = 0; y < height; y++)
		    {
			    var line = Read();
			    for (var x = 0; x < width; x++)
			    {
				    field[x, y] = line[x];
			    }
		    }

		    var (path, abPortal) = FindPath(field, (0, 0), (width - 1, height - 1), stepPrice);
		    var (_, baPortal) = FindPath(field, (width - 1, height - 1), (0, 0), stepPrice);

		    var portalPath = abPortal == -1 || baPortal == -1 ? -1 : abPortal + baPortal;
		    var result = (portalPath, path) switch
		    {
			    {portalPath: -1, path: -1} => -1,
			    {portalPath: -1} => path,
			    {path: -1} => portalPath,
			    _ => Math.Min(portalPath, path)
		    };
		    Console.WriteLine(result);
	    }

	    public static (long pathLength, long portalFromLength) FindPath(int[,] field, (int X, int Y) start, (int X, int Y) finish, int stepPrice)
	    {
		    if (start == finish) return (0, int.MaxValue);
		    
		    var width = field.GetLength(0);
		    var height = field.GetLength(1);
		    var workField = new int[width, height];
		    workField[finish.X, finish.Y] = -1;
		    
		    Queue<(int x, int y, int)> stepQueue = new Queue<(int x, int y, int step)>();
		    stepQueue.Enqueue((start.X, start.Y, 1));
		    var minPortal = field[start.X, start.Y] > 0 ? field[start.X, start.Y] : long.MaxValue;

		    while (stepQueue.TryDequeue(out var currentPoint))
		    {
			    var (currentX, currentY, step) = currentPoint;
		
			    var posibleMoves = new (int X, int Y)[] {
				    (currentX - 1, currentY),
				    (currentX + 1, currentY),
				    (currentX, currentY - 1),
				    (currentX, currentY + 1)
			    }.Where(p => p.X >= 0 && p.X < width && p.Y >= 0 && p.Y < height);
			    
			    foreach (var (x, y) in posibleMoves)
			    {
				    var cellValue = field[x, y];
				    if (cellValue == -1 || workField[x, y] > 0) continue;
				    
				    stepQueue.Enqueue((x, y, step + 1));
				    workField[x, y] = step;

				    if (cellValue > 0)
				    {
					    var portalPrice = cellValue + 1L * step * stepPrice;
						if (portalPrice < minPortal) minPortal = portalPrice;
				    }
			    }
		    }

		    var portalPath = minPortal == long.MaxValue ? -1 : minPortal;
		    var regularPath = workField[finish.X, finish.Y] == -1 ? -1 : 1L * workField[finish.X, finish.Y] * stepPrice;
		    return (regularPath, portalPath);
	    }
    }
}