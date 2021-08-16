using System;
using System.Linq;

namespace CodeforcesTasks.Contest1555
{
    public class TaskC
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.ReadLine();
                Console.WriteLine(Solve(Read(), Read()));
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