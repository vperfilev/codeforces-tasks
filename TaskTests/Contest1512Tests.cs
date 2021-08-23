using System;
using System.Collections.Generic;
using System.Linq;
using CodeforcesTasks.Contest1512;
using Xunit;

namespace TaskTests
{
    public class Contest1512Tests
    {
        [Fact]
        public void TaskCTest()
        {
            var b1 = new long[] { 2, 3, 7, 12, 2 };
            Assert.True(CheckCorrectionC(b1,TaskD.Solve(b1)));
            
            var b2 = new long[] { 9, 1, 7, 1, 6, 5 };
            Assert.True(TaskD.Solve(b2).Single() == -1);
            
            var b3 = new long[] { 18, 2, 2, 3, 2, 9, 2 };
            Assert.True(CheckCorrectionC(b3,TaskD.Solve(b3)));
            
            var b4 = new long[] { 2, 6, 9, 2, 1 };
            Assert.True(CheckCorrectionC(b4,TaskD.Solve(b4)));

            var b5 = new long[] { 1, 1, 1, 1, 2 };
            Assert.True(TaskD.Solve(b5).Single() == -1);
        }

        private bool CheckCorrectionC(long[] b, long[] a)
        {
            var diff = new List<long>(2);
            
            Array.Sort(a);
            Array.Sort(b);
            var aPointer = 0;
            var bPointer = 0;

            while (aPointer < a.Length && bPointer < b.Length)
            {
                if (a[aPointer] != b[bPointer])
                {
                    diff.Add(b[bPointer]);
                    bPointer++;
                    continue;
                }

                aPointer++;
                bPointer++;
            }

            while (bPointer < b.Length)
            {
                diff.Add(b[bPointer++]);
            }

            if (diff.Count != 2) return false;
            var aSum = a.Sum();
            return aSum == diff[0] || aSum == diff[1];
        }
    }
}