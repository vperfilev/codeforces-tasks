using System;

namespace CodeforcesTasks.Contest1547
{
    // https://codeforces.com/contest/1547/problem/A
    public class TaskA
    {
        private static (int, int) Read2()
        {
            var values = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            return (values[0], values[1]);
        }

        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                Console.ReadLine();
                var a = Read2();
                var b = Read2();
                var f = Read2();
                Console.WriteLine(Solve(a, b, f));
            }
        }

        public static int Solve((int x, int y) a, (int x, int y) b, (int x, int y) f)
        {
            var (minX, maxX) = a.x < b.x ? (a.x, b.x) : (b.x, a.x);
            var (minY, maxY) = a.y < b.y ? (a.y, b.y) : (b.y, a.y);

            var result = maxX - minX + maxY - minY;
            
            if (minX == f.x && maxX == f.x && minY < f.y && f.y < maxY)
            {
                return result + 2;
            } 
            
            if (minY == f.y && maxY == f.y && minX < f.x && f.x < maxX)
            {
                return result + 2;
            }

            return result;
        }
    }
}