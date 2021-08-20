using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1512
{
    public class TaskC
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                var numbers = Read();
                var line = Console.ReadLine();
                Console.WriteLine(Solve(line, numbers[0], numbers[1]));
            }
        }

        public static string Solve(string inputLine, int zeroCount, int oneCount)
        {
            var input = inputLine.ToArray();
            var lPointer = 0;
            var rPointer = input.Length - 1;
            var unknownPairs = new List<int>();
            while (lPointer <= rPointer)
            {
                if (lPointer == rPointer)
                {
                    if (input[lPointer] == '?')
                    {
                        if (zeroCount % 2 != 0)
                        {
                            input[lPointer] = '0';
                        }
                        else
                        {
                            input[lPointer] = '1';
                        }
                    }
                    if (input[lPointer] == '0') zeroCount--;
                    else oneCount--;
                    break;
                }
                if (input[lPointer] == '?' && input[rPointer] == '?')
                {
                    unknownPairs.Add(lPointer);
                }
                else
                {
                    input = FillStar(input, lPointer, rPointer);
                    input = FillStar(input, rPointer, lPointer);
                    
                    if (input[lPointer] == '0') zeroCount--;
                    else oneCount--;
                    
                    if (input[rPointer] == '0') zeroCount--;
                    else oneCount--;
                }

                if (input[lPointer] != input[rPointer]) return "-1";
                
                lPointer++;
                rPointer--;
            }

            if (zeroCount < 0 || zeroCount % 2 != 0 || oneCount < 0 || oneCount % 2 != 0) return "-1";

            input = FillPairs(input, unknownPairs.Take(zeroCount / 2), '0');
            input = FillPairs(input, unknownPairs.Skip(zeroCount / 2), '1');

            return new string(input);

            static char[] FillPairs(char[] input, IEnumerable<int> pairLefts, char fillValue)
            {
                foreach (var pairLeft in pairLefts)
                    input[input.Length - 1 - pairLeft] = input[pairLeft] = fillValue;

                return input;
            }

            static char[] FillStar(char[] input, int pointerA, int pointerB)
            {
                if (input[pointerA] != '?') return input;
                input[pointerA] = input[pointerB];
                return input;
            }
        }
    }
}