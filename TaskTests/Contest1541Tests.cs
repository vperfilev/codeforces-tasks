using System.Linq;
using CodeforcesTasks.Contest1541;
using Microsoft.VisualBasic;
using Xunit;

namespace TaskTests
{
    public class Contest1541Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.Equal("2 1", string.Join(" ",TaskA.Solve(2)));
            Assert.Equal("3 1 2", string.Join(" ",TaskA.Solve(3)));
            Assert.Equal("2 1 4 3", string.Join(" ",TaskA.Solve(4)));
            Assert.Equal("3 1 2 5 4", string.Join(" ",TaskA.Solve(5)));
            Assert.Equal("2 1 4 3 6 5", string.Join(" ",TaskA.Solve(6)));
            Assert.Equal("3 1 2 5 4 7 6", string.Join(" ",TaskA.Solve(7)));
        }
    }
}