using System;
using System.Linq;

namespace CodeforcesTasks.Contest1555
{
    public class TaskD
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var counts = Read();
            var line = Console.ReadLine();
            var solver = new Solver(line);
            
            for (var i = 0; i < counts[1]; i++)
            {
                var values = Read();
                Console.WriteLine(solver.GetAnswer(values[0], values[1]));
            }
        }

        public class Solver
        {
            private readonly string[] _patterns = new[] { "abc", "acb", "bac", "bca", "cab", "cba" };
            private readonly int[,] _solver;

            public Solver(string line)
            {
                _solver = new int[line.Length + 1, _patterns.Length];
                for (var i = 0; i < _patterns.Length; i++)
                {
                    var currentSum = 0;
                    for (var j = 1; j <= line.Length; j++)
                    {
                        if (line[j - 1] != _patterns[i][(j - 1) % 3])
                            currentSum++;
                        _solver[j, i] = currentSum;
                    }
                }
            }

            public int GetAnswer(int s, int e)
            {
                var bestAnswer = int.MaxValue;
                for (var i = 0; i < _patterns.Length; i++)
                {
                    var answer = _solver[e, i] - _solver[s - 1, i];
                    if (answer < bestAnswer)
                        bestAnswer = answer;
                }

                return bestAnswer;
            }
        }
        public static int Solve(int[] lineA, int[] lineB)
        {
            var bobAScore = lineA.Skip(1).Sum();
            var bobBScore = 0;
            var bobScore = bobAScore;
            for (var i = 1; i < lineA.Length; i++)
            {
                bobBScore += lineB[i - 1];
                bobAScore -= lineA[i];
                if (Math.Max(bobAScore, bobBScore) < bobScore)
                {
                    bobScore = Math.Max(bobAScore, bobBScore);
                }
            }

            return bobScore;
        }
    }
}