using CodeforcesTasks.Contest1526;
using Xunit;

namespace TaskTests
{
    public class Contest1526Tests
    {
        [Fact]
        public void TaskC1Test()
        {
            Assert.Equal(5, TaskC1.Solve(new [] {4, -4, 1, -3, 1, -3}));
            Assert.Equal(5, TaskC1.Solve(new [] {-3, -3, -7, -7, -1, -7, 3, 3, -2, -1, 0, -7}));
        }
    }
}