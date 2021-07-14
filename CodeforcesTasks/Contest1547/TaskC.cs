using System;
using System.Collections.Generic;

namespace CodeforcesTasks.Contest1547
{
    // https://codeforces.com/contest/1547/problem/C
    public class TaskC
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.ReadLine();
                var result = Solve(Read(), Read(), Read());
                Console.WriteLine(string.Join(" ", result));
            }
        }
        
        public static int[] Solve(int[] prms, int[] actionsP, int[] actionsM)
        {
            var fileLength = prms[0];
            var totalCount = prms[1] + prms[2];
            var allActions = new List<int>(totalCount);
            var indexP = 0;
            var indexM = 0;
            
            while (allActions.Count < totalCount)
            {
                int action;
                if (indexP >= actionsP.Length) action = actionsM[indexM++];
                else if (indexM >= actionsM.Length) action = actionsP[indexP++];
                else action = actionsP[indexP] < actionsM[indexM] ? actionsP[indexP++] : actionsM[indexM++];
                
                if (action == 0) fileLength++;
                else if (fileLength < action) return new [] {-1};
                
                allActions.Add(action);
            }

            return allActions.ToArray();
        } 
    }
}