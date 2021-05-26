using System;
 
namespace CodeforcesTasks.Contest1520
{
    // https://codeforces.com/contest/1520/problem/B
    public class TaskB2
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine()!);
            for (var testNo = 0; testNo < testCount; testNo++)
            {
                var result = FindSolution(Console.ReadLine());
                Console.WriteLine(result);
            }
        }
        
        public static long FindSolution(string number)
        {
            var addPoint = number[0];
            var letterPointer = 0;
            while (letterPointer < number.Length - 1 && number[letterPointer] == addPoint) letterPointer++;
            return (number.Length - 1) * 9 + int.Parse(addPoint.ToString()) - (number[letterPointer] >= addPoint ? 0 : 1);
        }
    }
}