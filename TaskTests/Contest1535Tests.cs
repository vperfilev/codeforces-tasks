using CodeforcesTasks.Contest1535;
using Xunit;

namespace TaskTests
{
    public class Contest1535Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.True(TaskA.Solve(3, 7, 9, 5));
            Assert.False(TaskA.Solve(4, 5, 6, 9));
            Assert.True(TaskA.Solve(5, 3, 8, 1));
            Assert.False(TaskA.Solve(6, 5, 3, 2));
        }
    }
}