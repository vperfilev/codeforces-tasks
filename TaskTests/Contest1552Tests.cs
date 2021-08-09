using CodeforcesTasks.Contest1552;
using Xunit;

namespace TaskTests
{
    public class Contest1552Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.Equal(2, TaskA.Solve("lol"));
            Assert.Equal(6, TaskA.Solve("codeforces"));
            Assert.Equal(0, TaskA.Solve("aaaaa"));
            Assert.Equal(4, TaskA.Solve("dcba"));
        }

        [Fact]
        public void TaskBTest()
        {
            Assert.Equal(1, TaskB.Solve(new []{new []{50000, 1, 50000, 50000, 50000}}));            
            Assert.Equal(-1, TaskB.Solve(new []{new []{10, 10, 20, 30, 30}, new []{20, 20, 30, 10, 10}, new []{30, 30, 10, 20, 20}}));            
            Assert.Equal(1, TaskB.Solve(new []{new []{1, 1, 1, 1, 1}, new []{2, 2, 2, 2, 2}, new []{3, 3, 3, 3, 3}}));            
            Assert.Equal(5, TaskB.Solve(new []{new []{9, 5, 3, 7, 1}, new []{7, 4, 1, 6, 8}, new []{5, 6, 7, 3, 2}, new []{6, 7, 8, 8, 6}, new []{4, 2, 2, 4, 5}, new []{8, 3, 6, 9, 4}}));            
            Assert.Equal(1, TaskB.Solve(new []{new []{12268, 40495, 25519, 3323, 22033}, new []{36932, 25287, 21924, 33587, 40516}}));            
        }
    }
}