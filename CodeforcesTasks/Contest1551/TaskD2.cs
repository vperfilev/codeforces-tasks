using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesTasks.Contest1551
{
    // https://codeforces.com/contest/1551/problem/D2
    public class TaskD2
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        private static readonly List<string> No = new List<string>{ "NO" };
        private static readonly (char letterA, char letterB) OddLetters = ('a', 'b');
        private static readonly (char letterA, char letterB) EvenLetters = ('c', 'd');
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var initValues = Read();
                var result = Solve(initValues[0], initValues[1], initValues[2]);
                foreach (var line in result)
                {
                    Console.WriteLine(line);
                }
            }
        }
        
        public static List<string> Solve(int rows, int columns, int k)
        {
            var result = new char[columns + columns % 2, rows + rows % 2];
            if (rows % 2 == 0 && columns % 2 == 0)
            {
                if (k % 2 != 0) return No;
                for (var x = 0; x < rows / 2; x++)
                for (var y = 0; y < columns / 2; y++)
                {
                    PutTwoItems(y, x, k > 0, result);
                    k -= 2;
                }
            }
            else if (rows % 2 == 0)
            {
                var maxHorizontal = rows * (columns / 2);
                if (!(k <= maxHorizontal && k % 2 == 0)) return No;
                for (var y = 0; y < columns / 2 + 1; y++)
                {
                    for (var x = 0; x < rows / 2 ; x++)
                    {
                        PutTwoItems(y, x, k > 0, result);
                        k -= 2;
                    }
                }
            }
            else
            {
                var horizontalSize = columns / 2;
                if (k < horizontalSize) return No;
                var solve = Solve(rows - 1, columns, k - horizontalSize);
                if (solve[0] == "NO") return solve;
                var lastLine = new StringBuilder(horizontalSize * 2);
                for (var i = 0; i < horizontalSize; i++)
                {
                    lastLine.Append(i % 2 == 0 ? "ee" : "ff");
                }
                solve.Add(lastLine.ToString());
                return solve;
            }

            var lines = new List<string>(rows + 1) {"YES"};
            for (var row = 0; row < rows; row++)
            {
                var lineBuilder = new StringBuilder();
                for (var column = 0; column < columns; column++)
                {
                    lineBuilder.Append(result[column, row]);
                }
                lines.Add(lineBuilder.ToString());
            }

            return lines;
        }

        private static void PutTwoItems(int x, int y, bool horizontal, char[,] field)
        {
            var (letterA, letterB) = (x + y) % 2 == 0 ? EvenLetters : OddLetters;
            x *= 2;
            y *= 2;
            field[x, y] = letterA;
            field[x + 1, y + 1] = letterB;
            field[x, y + 1] = horizontal ? letterB : letterA;
            field[x + 1, y] = horizontal ? letterA : letterB;
        }
    }
}