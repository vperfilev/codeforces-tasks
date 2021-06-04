using System;
using System.Linq;

namespace CodeforcesTasks.Contest1526
{
    public class TaskC1
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine()!);
            var result = Solve(Read(), size);
            Console.WriteLine(result);
        }

        public static long Solve(int[] drinks,  int drinkCount)
        {
            var dp = new long[drinkCount + 1, drinkCount + 1];
            for(var drinkNo = 1; drinkNo <= drinkCount; drinkNo++)
            {
                var prevHealth = long.MinValue;
                var maxHealth = prevHealth;
                
                for(var position = drinkNo; position <= drinkCount; position++)
                {			
                    if (dp[drinkNo - 1, position - 1] >= 0)
                    {
                        var health = Math.Max(prevHealth, drinks[position - 1] + dp[drinkNo - 1, position - 1]);
                        prevHealth = dp[drinkNo, position] = health;
                        maxHealth = Math.Max(health, maxHealth);
                    } 
                    else 
                    {
                        dp[drinkNo, position] = prevHealth;
                    }
                }
                if(maxHealth < 0) return --drinkNo;
            }
	
            return drinkCount;
        }
    }
}