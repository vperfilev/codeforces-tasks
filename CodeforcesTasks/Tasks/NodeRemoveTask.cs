namespace CodeforcesTasks.Tasks
{
    public static class NodeRemoveTask
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public override string ToString() => $"{Value} {Next}";
        }

        public static Node Remove(Node list, int number, out bool result)
        {
            result = false;
            if (number < 1) return list;
            
            var rightPointer = list;
            var leftPointer = list;
            
            while (number-- > 0)
            {
                if (rightPointer == null) return list;
                rightPointer = rightPointer.Next;
            }

            result = true;
            if (rightPointer == null) return list.Next;

            while (rightPointer.Next != null)
            {
                rightPointer = rightPointer.Next;
                leftPointer = leftPointer.Next;
            } 

            leftPointer.Next = leftPointer.Next.Next;
            
            return list;
        }
    }
}