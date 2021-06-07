using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1526
{
    // https://codeforces.com/contest/1526/problem/C2
    public class TaskC2
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            Console.ReadLine();
            var result = Solve(Read());
            Console.WriteLine(result);
        }

        public static int Solve(int[] drinks)
        {
            long currentHealth = 0;
            var drinkCount = 0;
            var takenDrinks = new SortedDictionary<int, int>();
            
            foreach(var drink in drinks) 
            {
                if (currentHealth >= -drink)
                {
                    AddDrink(drink);			
                }
                else
                {
                    if (!takenDrinks.Any()) continue;
                    var (minDrink,_) = takenDrinks.First();
                    if (minDrink >= drink) continue;
                    
                    RemoveDrink(minDrink);
                    AddDrink(drink);
                }
            }
            return drinkCount;

            void AddDrink(int drink)
            {
                currentHealth += drink;
                drinkCount++;
                if (drink >= 0) return;
                if (takenDrinks.ContainsKey(drink))
                    takenDrinks[drink]++;
                else
                    takenDrinks[drink] = 1;
            }

            void RemoveDrink(int drink)
            {
                currentHealth -= drink;
                drinkCount--;
                if (takenDrinks.TryGetValue(drink, out var count) && count > 1)
                { 
                    takenDrinks[drink]--;
                }
                else
                    takenDrinks.Remove(drink);
            }
        }
    }
}