using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace CodeforcesTasks.Contest1551
{
    public class TaskC
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var worldCount = int.Parse(Console.ReadLine()!);
                var worlds = new string[worldCount];
                for (var j = 0; j < worldCount; j++)
                {
                    worlds[j] = Console.ReadLine();
                }
                Console.WriteLine(Solve(worlds));
            }
        }
        
        private static readonly char[] Abc = new[] {'a', 'b', 'c', 'd', 'e'};
        
        public static int Solve(params string[] worlds)
        {
            var scores = worlds.Select(x => new AbcScore(x)).ToArray();
            var result = 0;
            
            foreach (var letter in Abc)
            {
                var worldsCount = 0;
                var currentScore = 0;
                var sortedScores = scores.OrderByDescending(x => x[letter]);
                foreach (var score in sortedScores)
                {
                    currentScore += score[letter];
                    if (currentScore > 0)
                    {
                        worldsCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                result = result < worldsCount ? worldsCount : result;
            }

            return result;

        }
        
        private class AbcScore
        {
            private readonly int[] _letterScore = new int[5];

            public AbcScore(string word)
            {
                var letterCount = word.Length;
                var letterCounts = new int[5];
                foreach (var letter in word)
                {
                    letterCounts[letter-'a']++;
                }

                for (var i = 0; i < Abc.Length; i++)
                {
                    _letterScore[i] = letterCounts[i] * 2 - letterCount;
                }
            }
            
            public int this [char letter] => _letterScore[letter - 'a'];
        }
    }
}