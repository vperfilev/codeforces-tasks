using System;

namespace CodeforcesTasks.Contest1547
{
    // https://codeforces.com/contest/1547/problem/E
    public class TaskE
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.ReadLine();
                var counts = Read();
                var result = Solve(counts[0] , counts[1], Read(), Read());
                Console.WriteLine(string.Join(" ", result));
            }
        }
        
        public static int[] Solve(int fieldSize, int unitCount, int[] unitPositions, int[] unitTemps)
        {
            var result = new int[fieldSize];
            var fromRightField = new int[fieldSize];
            
            for (var i = 0; i < unitCount; i++)
            {
                var position = unitPositions[i] - 1;
                var temp = unitTemps[i];
                result[position] = temp;
                fromRightField[position] = temp;
            }

            var prevValue = 2000000000; 
            for (var i = fieldSize -1; i >= 0; i--)
            {
                var cellValue = fromRightField[i];
                var newValue = prevValue + 1;
                if (cellValue > 0) newValue = Math.Min(newValue, cellValue);
                fromRightField[i] = newValue;
                prevValue = newValue;
            }
            
            prevValue = 2000000000; 
            for (var i = 0; i < fieldSize; i++)
            {
                var cellValue = result[i];
                var newValue = prevValue + 1;
                if (cellValue > 0) {newValue = Math.Min(newValue, cellValue);}
                result[i] = Math.Min(newValue, fromRightField[i]);
                prevValue = newValue;
            }
            
            return result;
        }
    }
}