using System.Linq;
using CodeforcesTasks.Tasks;
using Xunit;

namespace TaskTests
{
    public class NodeRemoveTaskTest
    {
        [Fact]
        public void Test1()
        {
            var list = CreateNodeList(1, 2, 3, 4, 5);

            var result =  NodeRemoveTask.Remove(list, 3, out _);
            
            Assert.Equal("1 2 4 5 ", result.ToString());
        }
        
        [Fact]
        public void Test2()
        {
            var list = CreateNodeList(1, 2, 3);

            var result =  NodeRemoveTask.Remove(list, 1, out _);
            
            Assert.Equal("1 2 ", result.ToString());
        }
        
        [Fact]
        public void Test3()
        {
            var list = CreateNodeList(1, 2, 3);

            var result =  NodeRemoveTask.Remove(list, 3, out _);
            
            Assert.Equal("2 3 ", result.ToString());
        }
        
        [Fact]
        public void Test4()
        {
            var list = CreateNodeList(1, 2, 3, 4, 5);

            var result =  NodeRemoveTask.Remove(list, 1, out _);
            
            Assert.Equal("1 2 3 4 ", result.ToString());
        }
        
        [Fact]
        public void Test5()
        {
            var list = CreateNodeList(1, 2, 3, 4, 5);

            var result =  NodeRemoveTask.Remove(list, 0, out _);
            
            Assert.Equal("1 2 3 4 5 ", result.ToString());
        }
        
        [Fact]
        public void Test6()
        {
            var list = CreateNodeList(1, 2, 3, 4, 5);

            var result =  NodeRemoveTask.Remove(list, 6, out _);
            
            Assert.Equal("1 2 3 4 5 ", result.ToString());
        }

        private NodeRemoveTask.Node CreateNodeList(params int[] values)
        {
            NodeRemoveTask.Node node = null; 
            foreach (var value in values.Reverse())
            {
                node = new NodeRemoveTask.Node {Value = value, Next = node};
            }

            return node;
        }
    }
}