using System;
using System.Linq;

namespace CodeforcesTasks.Contest1512
{
    public class TaskA
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                Console.ReadLine();
                var data = Read();
                var multiple = data[0];
                if (data[0] != data[1]) multiple = data[0] == data[2] ? data[0] : data[1];
                for (int j = 0; j < data.Length; j++)
                {
                    if (data[j]==multiple) continue;
                    Console.WriteLine(j + 1);
                    break;
                }
            }
        }
    }
}