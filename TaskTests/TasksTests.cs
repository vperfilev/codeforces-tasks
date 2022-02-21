using System.Linq;
using CodeforcesTasks.Tasks;
using Xunit;

namespace TaskTests
{
    public class TasksTests
    {
        [Theory]
        [InlineData(3, new[] {1,2,3,4,5,6,7}, new[] {5,6,7,1,2,3,4})]
        [InlineData(2, new[] {-1,-100,3,99}, new[] {3,99,-1,-100})]
        public void ShiftArrayTest(int shiftSize, int[] originalArray, int[] result)
        {
            ShiftArrayTask.Rotate(originalArray, shiftSize);
            
            Assert.Equal(result, originalArray);
        }
        
        [Theory]
        [InlineData(3, new[] {1,2,3,4,5,6,7}, new[] {5,6,7,1,2,3,4})]
        [InlineData(2, new[] {-1,-100,3,99}, new[] {3,99,-1,-100})]
        public void ShiftArrayTest2(int shiftSize, int[] originalArray, int[] result)
        {
            ShiftArrayTask.Rotate2(originalArray, shiftSize);
            
            Assert.Equal(result, originalArray);
        }
    }
}