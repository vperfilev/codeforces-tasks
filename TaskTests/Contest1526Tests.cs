using System;
using CodeforcesTasks.Contest1526;
using Xunit;

namespace TaskTests
{
    public class Contest1526Tests
    {
        [Fact]
        public void TaskC1Test()
        {
            Assert.Equal(5, TaskC1.Solve(new [] {4, -4, 1, -3, 1, -3}, 6));
            Assert.Equal(5, TaskC1.Solve(new [] {-3, -3, -7, -7, -1, -7, 3, 3, -2, -1, 0, -7}, 12));
            var data = Array.ConvertAll("1 1 2 0 1 -1 -1 -4 1 3 -4 3 0 1 -1 3 0 1 0 0 1 -1 -1 -2 -1 3 1 0 -1 3 -2 -4 -2 -3 -2 -3 2 -3 -1 0 -1 -3 1 -1 3 -1 2 1 2 -3 2 0 2 2 1 1 0 -1 -4 0 2 -1 -4 1 3 2 -2 0 3 -2 -4 2 -4 1 2 2 -2 1 2 -3 3 -4 1 -2 -4 0 -1 3 2 -4 3 -3 -2 -3 -3 -4 1 3 2 1 -4 1 -4 3 2 0 -1 3 1 -4 -3 -1 -3 -3 3 2 -3 0 2 2 -4 -4 -1 2 1 -2 3 -2 -1 -3 3 1 -2 -2 1 2 0 1 1 2 -3 2 -3 0 -1 1 2 -3 -1 2 1 1 -2 -2 -1 -4 -3 0 -3 -3 -2 1 0 -1 0 -3 2 -1 -2 -4 -1 -1 1 2 1 -2 2 -1 -3 -2 1 -1 -4 -3 1 2 3 -4 1 -2 3 3 -4 0 1 3 2 -1 -1 2 -3 1 1 3 -3".Split(), int.Parse);
            Assert.Equal(187, TaskC1.Solve(data, data.Length));            
        }
        
        [Fact]
        public void TaskC2Test()
        {
            Assert.Equal(5, TaskC2.Solve(new [] {4, -4, 1, -3, 1, -3}));
            Assert.Equal(5, TaskC2.Solve(new [] {-3, -3, -7, -7, -1, -7, 3, 3, -2, -1, 0, -7}));
            
            var data = Array.ConvertAll("1 1 2 0 1 -1 -1 -4 1 3 -4 3 0 1 -1 3 0 1 0 0 1 -1 -1 -2 -1 3 1 0 -1 3 -2 -4 -2 -3 -2 -3 2 -3 -1 0 -1 -3 1 -1 3 -1 2 1 2 -3 2 0 2 2 1 1 0 -1 -4 0 2 -1 -4 1 3 2 -2 0 3 -2 -4 2 -4 1 2 2 -2 1 2 -3 3 -4 1 -2 -4 0 -1 3 2 -4 3 -3 -2 -3 -3 -4 1 3 2 1 -4 1 -4 3 2 0 -1 3 1 -4 -3 -1 -3 -3 3 2 -3 0 2 2 -4 -4 -1 2 1 -2 3 -2 -1 -3 3 1 -2 -2 1 2 0 1 1 2 -3 2 -3 0 -1 1 2 -3 -1 2 1 1 -2 -2 -1 -4 -3 0 -3 -3 -2 1 0 -1 0 -3 2 -1 -2 -4 -1 -1 1 2 1 -2 2 -1 -3 -2 1 -1 -4 -3 1 2 3 -4 1 -2 3 3 -4 0 1 3 2 -1 -1 2 -3 1 1 3 -3".Split(), int.Parse);
            Assert.Equal(187, TaskC2.Solve(data));
        }

        [Fact]
        public void TaskBTest()
        {
            Assert.True(TaskB.Solve(33));
            Assert.True(TaskB.Solve(144));
            Assert.True(TaskB.Solve(1440));
            Assert.False(TaskB.Solve(69));
        }
    }
}