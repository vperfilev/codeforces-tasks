using System.Threading.Tasks;
using CodeforcesTasks.Contest1547;
using Xunit;

namespace TaskTests
{
    public class Content1547Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.Equal(4, TaskA.Solve((1, 1), (3, 3), (2, 2)));
            Assert.Equal(6, TaskA.Solve((2, 5), (2, 1), (2, 3)));
            Assert.Equal(41, TaskA.Solve((1000, 42), (1000, 1), (1000, 1000)));
            Assert.Equal(4, TaskA.Solve((1, 10), (3, 10), (2, 10)));
            Assert.Equal(4, TaskA.Solve((3, 8), (7, 8), (3, 7)));
            Assert.Equal(2, TaskA.Solve((2, 1), (4, 1), (1, 1)));
            Assert.Equal(334, TaskA.Solve((1, 344), (1, 10), (1, 1)));

        }

        [Fact]
        public void TaskBTest()
        {
            Assert.True(TaskB.Solve("a"));
            Assert.True(TaskB.Solve("ba"));
            Assert.True(TaskB.Solve("ab"));
            Assert.True(TaskB.Solve("bac"));
            Assert.True(TaskB.Solve("ihfcbadeg"));
            Assert.False(TaskB.Solve("z"));
            Assert.False(TaskB.Solve("aa"));
            Assert.False(TaskB.Solve("ca"));
            Assert.False(TaskB.Solve("acb"));
            Assert.False(TaskB.Solve("xyz"));
            Assert.False(TaskB.Solve("ddcba"));
        }

        [Fact]
        public void TaskCTest()
        {
            Assert.Equal("0 2 0 5", string.Join(" ",TaskC.Solve(new []{3, 2, 2}, new []{2, 0}, new []{0, 5})));
            Assert.Equal("0 2 0 5 6", string.Join(" ",TaskC.Solve(new []{4, 3, 2}, new []{2, 0, 5}, new []{0, 6})));
            Assert.Equal("-1", string.Join(" ",TaskC.Solve(new []{0, 2, 2}, new []{1, 0}, new []{2, 3})));
            Assert.Equal("0 6 0 7 0 8 0 9", string.Join(" ",TaskC.Solve(new []{5, 4, 4}, new []{6, 0, 8, 0}, new []{0, 7, 0, 9})));
            Assert.Equal("-1", string.Join(" ",TaskC.Solve(new []{5, 4, 1}, new []{8, 7, 8, 0}, new []{0})));
        }

        [Fact]
        public void TaskETest()
        {
            Assert.Equal("15 14 15 16 16 17", string.Join(" ", TaskE.Solve(6, 2, new []{2, 5}, new [] {14, 16})));
            Assert.Equal("36 35 34 33 32 31 30 31 32 33", string.Join(" ", TaskE.Solve(10, 1, new []{7}, new []{30})));
            Assert.Equal("1 2 3 4 5", string.Join(" ", TaskE.Solve(5, 5, new []{3, 1, 4, 2, 5}, new []{3, 1, 4, 2, 5})));
            Assert.Equal("1000000000 1000000001 1000000002 1000000003 1000000004 1000000005 1000000006", string.Join(" ", TaskE.Solve(7, 1, new []{1}, new []{1000000000})));
            Assert.Equal("5 6 5 6 6 5", string.Join(" ", TaskE.Solve(6, 3, new []{6, 1, 3}, new []{5, 5, 5})));
        }
    }
}