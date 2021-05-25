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

        [Fact]
        public void TaskBTest()
        {   
            Assert.Equal(1, TaskB.FindSolution("1"));
            Assert.Equal(2, TaskB.FindSolution("2"));
            Assert.Equal(3, TaskB.FindSolution("3"));
            Assert.Equal(4, TaskB.FindSolution("4"));
            Assert.Equal(5, TaskB.FindSolution("5"));
            Assert.Equal(10, TaskB.FindSolution("20"));
            Assert.Equal(17, TaskB.FindSolution("95"));
            Assert.Equal(18, TaskB.FindSolution("100"));
            Assert.Equal(19, TaskB.FindSolution("120"));
        }
    }
}