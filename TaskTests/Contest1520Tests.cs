using CodeforcesTasks.Contest1520;
using Xunit;

namespace TaskTests
{
    public class Contest1520Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.True(TaskA.IsSuspicious("ABA"));
            Assert.True(TaskA.IsSuspicious("DDBBCCCBBEZ"));
            Assert.False(TaskA.IsSuspicious("FFGZZZY"));
            Assert.False(TaskA.IsSuspicious("Z"));
            Assert.False(TaskA.IsSuspicious("AB"));
        }
    }
}