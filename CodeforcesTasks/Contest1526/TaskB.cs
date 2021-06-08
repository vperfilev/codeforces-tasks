using System;

namespace CodeforcesTasks.Contest1526
{
    // https://codeforces.com/contest/1526/problem/B
    public class TaskB
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine()!);
                Console.WriteLine(Solve(number) ? "YES" : "NO");
            }
        }
        
        public static bool Solve(int number)
        {
            if(number > 1100) return true;
	
            while (number >= 11)
            {
                if (number % 11 == 0) return true;
                number -= 111;
            }
            return number == 0 ? true : false;
        }
    }
}