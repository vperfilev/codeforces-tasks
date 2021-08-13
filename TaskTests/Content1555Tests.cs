using CodeforcesTasks.Contest1555;
using Xunit;

namespace TaskTests
{
    public class Content1555Tests
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

        [Fact]
        public void TaskBTest()
        {
            Assert.Equal(1, TaskB.Solve((8, 5), (2, 1), (7, 4), (4, 2)));            
            Assert.Equal(-1, TaskB.Solve((5, 4), (2, 2), (5, 4), (3, 3)));            
            Assert.Equal(2, TaskB.Solve((1, 8), (0, 3), (1, 6), (1, 5)));            
            Assert.Equal(2, TaskB.Solve((8, 1), (3, 0), (6, 1), (5, 1)));            
            Assert.Equal(0, TaskB.Solve((8, 10), (4, 5), (7, 8), (8, 5)));
            Assert.Equal(1, TaskB.Solve((1, 2), (0, 0), (1, 1), (1, 1)));
        }
        
        /*
,

         *
         * 
         */
    }
}