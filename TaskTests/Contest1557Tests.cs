using CodeforcesTasks.Contest1557;
using Xunit;

namespace TaskTests
{
    public class Contest1557Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.True(TaskA.Solve(new long[] { 3, 1, 2 }) - 4.5 < 0.0000001);
            Assert.True(TaskA.Solve(new long[] { -7, -6, -6 }) + 12.5 < 0.0000001);
            Assert.True(TaskA.Solve(new long[] { 2, 2, 2 })- 4 < 0.0000001);
            Assert.True(TaskA.Solve(new long[] { 17, 3, 5, -3 })- 18.666666667 < 0.0000001);
        }

        [Fact]
        public void TaskBTest()
        {
            Assert.True(TaskB.Solve(new []{6, 3, 4, 2, 1}, 4));
            Assert.False(TaskB.Solve(new []{1, -4, 0, -2}, 2));
            Assert.True(TaskB.Solve(new []{1, 2, 3, 4, 5}, 1));
        }
    }
}