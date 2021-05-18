using System;

namespace CodeforcesTasks.Contest1525
{
    // https://codeforces.com/contest/1525/problem/B
    public class TaskB
    {
        static void Main(string[] args)
        {
            var testNumber = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < testNumber; i++)
            {
                var itemsCount = Console.ReadLine();
                var items = Console.ReadLine();
                var (data, isSorted) = ParseItems(items, int.Parse(itemsCount!));
                Console.WriteLine(isSorted ? 0 : FindSolution(data));
            }
        }

        private static (int[] data, bool isSorted) ParseItems(string dataString, int itemsCount)
        {
            var currentSymbolNo = 0;
            var currentParsedItem = 0;
            var isSorted = true;
            var parsedItems = new int[itemsCount];
            
            for (var i = 0; i < dataString.Length; i++)
            {
                if (dataString[i] != ' ') continue;
                AddValue(currentSymbolNo, i);
                currentSymbolNo = ++i;
            }
            AddValue(currentSymbolNo, dataString.Length);
            return (parsedItems, isSorted);
            
            void AddValue(int start, int end)
            {
                var parsedValue = int.Parse(dataString[start..end]);
                parsedItems[currentParsedItem++] = parsedValue;
                isSorted &= currentParsedItem == parsedValue;
            }
        }

        private static int FindSolution(int[] data)
        {
            if (data[0] == data.Length && data[^1] == 1)
                return 3;
            if (data[0] == 1 || data[^1] == data.Length)
                return 1;
            return 2;
        }
    }
}