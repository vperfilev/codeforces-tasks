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
        /*
3, 1, 2

4.500000000
-12.500000000
4.000000000
18.666666667

         */
    }
}