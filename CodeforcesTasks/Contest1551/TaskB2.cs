using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1551
{
    // https://codeforces.com/contest/1551/problem/B2
    public class TaskB2
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var colorCount = Read()[1];
                Console.WriteLine(Solve(Read(), colorCount));
            }
        }
        
        public static string Solve(int[] sequence, int colourCount)
        {
            var nodes = sequence.Select(value => new Node{Value = value, Color =  0}).ToArray();

            var selectedNodes = nodes.GroupBy(x => x.Value)
                .Select(group => group.Take(colourCount))
                .SelectMany(x => x).ToList();
            var nodeToSkip = selectedNodes.Count % colourCount;

            var color = 0;
            foreach (var node in selectedNodes.Skip(nodeToSkip)) node.Color = (color++ % colourCount) + 1;
            
            return string.Join(' ', nodes.Select(x => x.Color));
        }

        private class Node
        {
            public int Value { get; set; }
            public int Color { get; set; }
        }
    }
}