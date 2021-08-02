using System.Diagnostics;
using System.Linq;
using CodeforcesTasks.Contest1551;
using Xunit;

namespace TaskTests
{
    public class Contest1551Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.Equal((334, 333), TaskA.Solve(1000));
            Assert.Equal((10, 10), TaskA.Solve(30));
            Assert.Equal((1, 0), TaskA.Solve(1));
            Assert.Equal((10, 11), TaskA.Solve(32));
            Assert.Equal((333333334, 333333333), TaskA.Solve(1000000000));
            Assert.Equal((1, 2), TaskA.Solve(5));
        }

        [Fact]
        public void TaskBTest()
        {
            Assert.Equal(2, TaskB1.Solve("kzaaa"));
            Assert.Equal(5, TaskB1.Solve("codeforces"));
            Assert.Equal(3, TaskB1.Solve("archive"));
            Assert.Equal(0, TaskB1.Solve("y"));
            Assert.Equal(1, TaskB1.Solve("xxxxxx"));
        }

        [Fact]
        public void TaskB2Test()
        {
            Assert.Equal("0 1 3 1 2 0 3 2 1 2 3", TaskB2.Solve(new []{5, 3, 1, 1, 1, 1, 10, 3, 10, 10, 2}, 3));
            Assert.Equal("1 3 1 2 0 3 2 1 2 3", TaskB2.Solve(new []{3, 1, 1, 1, 1, 10, 3, 10, 10, 2}, 3));
            Assert.Equal("1 2 3 4", TaskB2.Solve(new []{1, 1, 1, 1}, 4));
            Assert.Equal("1", TaskB2.Solve(new []{1}, 1));
            Assert.Equal("1 1 1 0 1 1 1 1 0 0 0 1 0", TaskB2.Solve(new []{3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9}, 1));
            Assert.Equal("1 1 1 2 2 2 2 1 1 2 0 2 1", TaskB2.Solve(new []{3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9}, 2));
            Assert.Equal("0 2 1 3 2 2 1 2 3 1 1 3 3", TaskB2.Solve(new []{3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9}, 3));
            
            var sw = Stopwatch.StartNew();
            var result = TaskB2.Solve(Enumerable.Range(1, 200000).ToArray(), 200000);
            var elapsedMilliseconds = sw.ElapsedMilliseconds;
            Assert.True(elapsedMilliseconds < 2000);
            Assert.Equal(string.Join(' ', Enumerable.Range(1, 200000).ToArray()), result);
        }

        [Fact]
        public void TaskCTest()
        {
            Assert.Equal(3, TaskC.Solve("bac", "aaada", "e")); 
            Assert.Equal(2, TaskC.Solve("aba", "abcde", "aba")); 
            Assert.Equal(0, TaskC.Solve("baba", "baba")); 
            Assert.Equal(2, TaskC.Solve("ab", "ab", "c", "bc")); 
            Assert.Equal(3, TaskC.Solve("cbdca", "d", "a", "d", "e")); 
            Assert.Equal(2, TaskC.Solve("b", "c", "ca")); 
        }
    }
}