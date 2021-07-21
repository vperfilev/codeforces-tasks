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

        [Fact]
        public void TaskCTest()
        {
            Assert.Equal(2, TaskC.Solve(3, 4, 7, new [] {5, 1, 2}));
            Assert.Equal(7, TaskC.Solve(5, 5, 8, new [] { 5, 1, 2, 4, 3}));
            Assert.Equal(0, TaskC.Solve(4, 100, 1000, new [] { 1, 1, 1, 1}));
            Assert.Equal(1, TaskC.Solve(5, 9, 13, new [] { 2, 5, 5, 1, 1}));
        }

        [Fact]
        public void TaskETest()
        {
            var dataSet1 = new[]
            {
                "a := h",
                "b := aha",
                "c = a + b",
                "c = c + c",
                "e = c + c",
                "d = a + c"
            };
            Assert.Equal(3, TaskE.Solve(dataSet1));

            var dataSet2 = new[]
            {
                "x := haha",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x",
                "x = x + x"
            };
            Assert.Equal(32767, TaskE.Solve(dataSet2));
            
            Assert.Equal(0, TaskE.Solve(new []{"haha := hah"}));

            var dataSet4 = new[]
            {
                "haahh := aaaha",
                "ahhhh = haahh + haahh",
                "haahh = haahh + haahh",
                "ahhhh = ahhhh + haahh",
                "ahhaa = haahh + ahhhh"
            };
            
            Assert.Equal(0, TaskE.Solve(dataSet4));
        }
    }
}