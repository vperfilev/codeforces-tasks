using System;

namespace CodeforcesTasks.Contest1547
{
    public class TaskB
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var line = Console.ReadLine();
                Console.WriteLine(Solve(line) ? "YES" : "NO");
            }
        }
        
        public static bool Solve(string input)
        {
            var nextLetter = 'a';
            
            var start = input.IndexOf(nextLetter);
            if (start == -1) return false;
            
            var downIndex = start - 1;
            var upIndex = start + 1;
            while (nextLetter < 'z' && (downIndex >= 0 || upIndex < input.Length))
            {
                nextLetter++;
                
                if (downIndex >= 0 && input[downIndex] == nextLetter)
                    downIndex--;
                else if (upIndex < input.Length && input[upIndex] == nextLetter)
                    upIndex++;
                else
                    return false;
            }

            return true;
        }
    }
}