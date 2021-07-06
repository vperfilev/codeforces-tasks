using CodeforcesTasks.Contest1542;
using Xunit;

namespace TaskTests
{
    public class Contest1542Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.True(TaskA.Solve(new [] {2, 3, 4, 5}));
            Assert.False(TaskA.Solve(new [] {2, 3, 4, 5, 5, 5}));
            Assert.False(TaskA.Solve(new [] {2, 4}));
            Assert.True(TaskA.Solve(new [] {2, 3}));
            Assert.False(TaskA.Solve(new [] {1, 5, 3, 2, 6, 7, 3, 4}));
        }
    }
}