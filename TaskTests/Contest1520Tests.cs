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

        [Fact]
        public void TaskETest()
        {
            Assert.Equal(1, TaskE.Solve("**.*.."));
            Assert.Equal(0, TaskE.Solve("*****"));
            Assert.Equal(0, TaskE.Solve(".*."));
            Assert.Equal(0, TaskE.Solve("..."));
            Assert.Equal(9, TaskE.Solve("*.*...*.**"));
        }

        [Fact]
        public void TaskGTest()
        {
            var array = new [,]
            {
                {0, -1, 0, 1, -1},
                {0, 20, 0, 0, -1},
                {-1, -1, -1, -1, -1},
                {3, 0, 0, 0, 0},
                {-1, 0, 0, 0, 0}
            };
            
            Assert.Equal((-1,6), TaskG.FindPath(array, (0,0), (4,4), 1));
            Assert.Equal((-1,8), TaskG.FindPath(array, (4,4), (0,0), 1));

            var array2 = new[,]
            {
                {0, -1},
                {0, 10},
                {8, 4},
                {0, 0},
                {0, 0},
                {-1, 0},
                {0, 0},
                {0, 0},
                {0, 0},
                {4, 0},
            };
            Assert.Equal((20,10), TaskG.FindPath(array2, (0,0), (9,1), 2));
            Assert.Equal((20,6), TaskG.FindPath(array2, (9,1), (0,0), 2));

            var array3 = new[,]
            {
                {0, 0, 0, 1, 0, 0},
                {-1, -1, 0, 0, 0, -1},
                {9, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 3}
            };
            Assert.Equal((28,7), TaskG.FindPath(array3, (0,0), (9,5), 2));
            Assert.Equal((28,3), TaskG.FindPath(array3, (9,5), (0,0), 2));
        }
    }
}