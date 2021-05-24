using System;
using System.Collections.Generic;

namespace CodeforcesTasks.Contest1520
{
    // https://codeforces.com/contest/1520/problem/A
    public class TaskA
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.ReadLine();
                var isSuspicious = IsSuspicious(Console.ReadLine());
                Console.WriteLine(isSuspicious ? "NO" : "YES");
            }
        }
        
        public static bool IsSuspicious(string tasks)
        {
            var prevTask = char.MinValue;
            var knownTasks = new HashSet<char>();
            foreach (var currentTask in tasks)
            {
                if (currentTask == prevTask) continue;
                prevTask = currentTask;
                if (!knownTasks.Add(currentTask))
                    return true;
            }

            return false;
        }
    }
}