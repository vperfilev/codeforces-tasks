using System;
using System.Linq;

namespace CodeforcesTasks.Contest1526
{
    public class TaskC1
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            Console.ReadLine();
            var drinks = Read();
            var result = Solve(drinks);
            Console.WriteLine(result);
        }

        public static long Solve(int[] drinks)
        {
            var dp = new long[drinks.Count() + 1, drinks.Count() + 1];
            var drinkCount = 0;
            for(drinkCount = 1; drinkCount <= drinks.Count(); drinkCount++)
            {
                var prev = long.MinValue;
                var maxInLine = prev;
                for(var position = drinkCount; position <= drinks.Count(); position++)
                {			
                    long newVal;
                    if (dp[drinkCount - 1, position - 1] >= 0)
                    {
                        newVal = drinks[position - 1] + dp[drinkCount - 1, position - 1];
                    } else 
                    {
                        newVal = long.MinValue;
                    }
                    var max = Math.Max(prev, newVal);
                    dp[drinkCount, position] = max;
                    prev = dp[drinkCount, position];
                    maxInLine = Math.Max(max, maxInLine);
                }
                if(maxInLine < 0) 
                    break;
            }
	
            return --drinkCount;
        }
    }
}