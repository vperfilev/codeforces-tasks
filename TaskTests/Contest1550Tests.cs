using CodeforcesTasks.Contest1550;
using Xunit;

namespace TaskTests
{
    public class Contest1550Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.Equal(1, TaskA.Solve(1));
            Assert.Equal(3, TaskA.Solve(8));
            Assert.Equal(3, TaskA.Solve(7));
            Assert.Equal(7, TaskA.Solve(42));
        }

        [Fact]
        public void TaskBTest()
        {
            Assert.Equal(6, TaskB.Solve(3, 2,0, "000"));
            Assert.Equal(15, TaskB.Solve(5, -2,5, "11001"));
            Assert.Equal(-2, TaskB.Solve(6, 1, -4, "100111"));
        }
    }
}