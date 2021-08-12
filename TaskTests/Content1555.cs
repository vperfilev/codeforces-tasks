using CodeforcesTasks.Contest1555;
using Xunit;

namespace TaskTests
{
    public class Content1555
    {
        [Fact]
        public void TaskATest()
        {
            Assert.Equal(30, TaskA.Solve(12));
            Assert.Equal(40, TaskA.Solve(15));
            Assert.Equal(750, TaskA.Solve(300));
            Assert.Equal(15, TaskA.Solve(1));
            Assert.Equal(25000000000000000, TaskA.Solve(9999999999999999));
            Assert.Equal(15, TaskA.Solve(3));
        }
    }
}/*
6






*/
/*
Assert.Equal(30, TaskA.Solve(12));
Assert.Equal(40, TaskA.Solve(15));
Assert.Equal(750, TaskA.Solve(300));
Assert.Equal(15, TaskA.Solve(1));
Assert.Equal(25000000000000000, TaskA.Solve(9999999999999999));
Assert.Equal(15, TaskA.Solve(3));
*/