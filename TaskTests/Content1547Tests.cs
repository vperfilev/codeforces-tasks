using CodeforcesTasks.Contest1547;
using Xunit;

namespace TaskTests
{
    public class Content1547Tests
    {
        [Fact]
        public void TaskATest()
        {
            Assert.Equal(4, TaskA.Solve((1, 1), (3, 3), (2, 2)));
            Assert.Equal(6, TaskA.Solve((2, 5), (2, 1), (2, 3)));
            Assert.Equal(41, TaskA.Solve((1000, 42), (1000, 1), (1000, 1000)));
            Assert.Equal(4, TaskA.Solve((1, 10), (3, 10), (2, 10)));
            Assert.Equal(4, TaskA.Solve((3, 8), (7, 8), (3, 7)));
            Assert.Equal(2, TaskA.Solve((2, 1), (4, 1), (1, 1)));
            Assert.Equal(334, TaskA.Solve((1, 344), (1, 10), (1, 1)));

        }

        [Fact]
        public void TaskBTest()
        {
            Assert.True(TaskB.Solve("a"));
            Assert.True(TaskB.Solve("ba"));
            Assert.True(TaskB.Solve("ab"));
            Assert.True(TaskB.Solve("bac"));
            Assert.True(TaskB.Solve("ihfcbadeg"));
            Assert.False(TaskB.Solve("z"));
            Assert.False(TaskB.Solve("aa"));
            Assert.False(TaskB.Solve("ca"));
            Assert.False(TaskB.Solve("acb"));
            Assert.False(TaskB.Solve("xyz"));
            Assert.False(TaskB.Solve("ddcba"));
        }

    }
}