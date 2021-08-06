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
    }
}