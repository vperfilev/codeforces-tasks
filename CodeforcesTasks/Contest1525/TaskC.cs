using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1525
{
    // https://codeforces.com/contest/1525/problem/C
    public class TaskC
    {
        static void Main(string[] args)
        {
            var testNumber = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < testNumber; i++)
            {
                var firstLine = Console.ReadLine();
                var spaceIndex = firstLine!.IndexOf(' ');
                var botCount = int.Parse(firstLine[0..spaceIndex]);
                var rightWall = int.Parse(firstLine[(spaceIndex + 1)..]);
                var coords = Console.ReadLine();
                var directions = Console.ReadLine();
                var bots = ParseBots(coords, directions, botCount);

                var (oddBots, evenBots) = SplitBots(bots);
                FindSolution(oddBots, rightWall);
                FindSolution(evenBots, rightWall);

                var result = string.Join(' ', bots.Select(b => b.ExplosionTime.ToString()));
                Console.WriteLine(result);
            }
        }

        private static Bot[] ParseBots(string coords, string direction, int botCount)
        {
            var firstSymbol = 0;
            var lastSymbol = 0;
            var bots = new Bot[botCount];

            for (var i = 0; i < botCount; i++)
            {
                var isLeftDirected = direction[i * 2] == 'L';
                while (lastSymbol < coords.Length && coords[lastSymbol] != ' ') lastSymbol++;
                var startPoint = int.Parse(coords[firstSymbol..lastSymbol]);
                firstSymbol = ++lastSymbol;
                bots[i] = new Bot(isLeftDirected, startPoint);
            }

            return bots;
        }

        private static (List<Bot> oddBots, List<Bot> evenBots) SplitBots(Bot[] bots)
        {
            var evenBots = new List<Bot>();
            var oddBots = new List<Bot>();
            foreach (var bot in bots)
            {
                if (bot.StartPoint % 2 == 0)
                    evenBots.Add(bot);
                else
                    oddBots.Add(bot);
            }

            return (oddBots, evenBots);
        }

        private static void FindSolution(List<Bot> bots, int rightWall)
        {
            var orderedBots = bots.OrderBy(b => b.StartPoint).ToList();
            var goingLeft = new Stack<Bot>();
            var goingRight = new Stack<Bot>();

            foreach (var bot in orderedBots)
            {
                if (bot.LeftDirected)
                {
                    if (goingRight.TryPop(out var rightDirected))
                    {
                        var explosionTime = Math.Abs(bot.StartPoint - rightDirected.StartPoint) / 2;
                        bot.ExplosionTime = rightDirected.ExplosionTime = explosionTime;
                    }
                    else
                    {
                        goingLeft.Push(bot);
                    }
                }
                else
                {
                    goingRight.Push(bot);
                }
            }

            var leftSurvivingBot = goingLeft.Count % 2 == 0 ? null : goingLeft.Pop();
            while (goingLeft.Count > 0)
            {
                var firstBot = goingLeft.Pop();
                var secondBot = goingLeft.Pop();
                var explosionTime = (firstBot.StartPoint + secondBot.StartPoint) / 2;
                firstBot.ExplosionTime = secondBot.ExplosionTime = explosionTime;
            }

            while (goingRight.Count > 1)
            {
                var firstBot = goingRight.Pop();
                var secondBot = goingRight.Pop();
                var explosionTime = (rightWall * 2 - firstBot.StartPoint - secondBot.StartPoint) / 2;
                firstBot.ExplosionTime = secondBot.ExplosionTime = explosionTime;
            }

            if (leftSurvivingBot != null && goingRight.Count > 0)
            {
                var rightSurvivingBot = goingRight.Pop();
                var leftStartPoint = -leftSurvivingBot.StartPoint;
                var rightStartPoint = rightWall * 2 - rightSurvivingBot.StartPoint;
                var explosionTime = (rightStartPoint - leftStartPoint) / 2;
                leftSurvivingBot.ExplosionTime = rightSurvivingBot.ExplosionTime = explosionTime;
            }
        }

        private class Bot
        {
            public bool LeftDirected { get; }
            public int StartPoint { get; }
            public int ExplosionTime { get; set; } = -1;

            public Bot(bool leftDirected, int startPoint)
            {
                LeftDirected = leftDirected;
                StartPoint = startPoint;
            }
        }
    }
}