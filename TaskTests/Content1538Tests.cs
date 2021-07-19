using CodeforcesTasks.Contest1538;
using Xunit;

namespace TaskTests
{
    public class Content1538Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.Equal(2, TaskA.Solve(5, new [] {1, 5, 4, 3, 2}));
            Assert.Equal(4, TaskA.Solve(8, new [] {2, 1, 3, 4, 5, 6, 8, 7}));
            Assert.Equal(5, TaskA.Solve(8, new [] {4, 2, 3, 1, 8, 6, 7, 5}));
            Assert.Equal(3, TaskA.Solve(4, new [] {3, 4, 2, 1}));
            Assert.Equal(2, TaskA.Solve(4, new [] {2, 3, 1, 4}));            
        }

        [Fact]
        public void TaskBTest()
        {
            Assert.Equal(2, TaskB.Solve(4, new [] {4, 5, 2, 5}));
            Assert.Equal(1, TaskB.Solve(2, new [] {0, 4}));
            Assert.Equal(-1, TaskB.Solve(5, new [] {10, 8, 5, 1, 4}));
            Assert.Equal(0, TaskB.Solve(1, new [] {10000}));
            Assert.Equal(0, TaskB.Solve(7, new [] {1, 1, 1, 1, 1, 1, 1}));
        }
    }
}