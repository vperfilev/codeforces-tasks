using System;

namespace CodeforcesTasks.Contest1535
{
    
    // https://codeforces.com/contest/1535/problem/A
    public class TaskA
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < count; i++)
            {
                var input = Read();
                var isFair  = Solve(input[0], input[1], input[2], input[3]);
                Console.WriteLine(isFair ? "YES" : "NO");
            }
        }
        
        public static bool Solve(int a, int b, int c, int d) 
        {
            (a,b) = a<b? (a,b) : (b,a);
            (c,d) = c<d? (c,d) : (d,c);
            return b > c && d > a;
        }
    }
}