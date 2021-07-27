using CodeforcesTasks.Contest1551;
using Xunit;

namespace TaskTests
{
    public class Contest1551Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.Equal((334, 333), TaskA.Solve(1000));
            Assert.Equal((10, 10), TaskA.Solve(30));
            Assert.Equal((1, 0), TaskA.Solve(1));
            Assert.Equal((10, 11), TaskA.Solve(32));
            Assert.Equal((333333334, 333333333), TaskA.Solve(1000000000));
            Assert.Equal((1, 2), TaskA.Solve(5));
            
            
            
            
            
            
        }
    }
}