using System;
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
        
        [Fact]
        public void TaskB2Test()
        {   
            Assert.Equal(1, TaskB2.FindSolution("1"));
            Assert.Equal(2, TaskB2.FindSolution("2"));
            Assert.Equal(3, TaskB2.FindSolution("3"));
            Assert.Equal(4, TaskB2.FindSolution("4"));
            Assert.Equal(5, TaskB2.FindSolution("5"));
            Assert.Equal(10, TaskB2.FindSolution("20"));
            Assert.Equal(17, TaskB2.FindSolution("95"));
            Assert.Equal(18, TaskB2.FindSolution("100"));
            Assert.Equal(19, TaskB2.FindSolution("120"));
        }

        [Fact]
        public void TaskDTest()
        {
            Assert.Equal(1, TaskD.FindSolution(Array.ConvertAll("3 5 1 4 6 6".Split(), int.Parse)));
            Assert.Equal(3, TaskD.FindSolution(Array.ConvertAll("1 2 3".Split(), int.Parse)));
            Assert.Equal(3, TaskD.FindSolution(Array.ConvertAll("1 3 3 4".Split(), int.Parse)));
            Assert.Equal(10, TaskD.FindSolution(Array.ConvertAll("1 6 3 4 5 6".Split(), int.Parse)));
        }
    }
}