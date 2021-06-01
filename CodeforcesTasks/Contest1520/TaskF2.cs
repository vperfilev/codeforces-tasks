using System;

namespace CodeforcesTasks.Contest1520
{
    public class TaskF2
    {
        static int[] Read() => Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        static (int, int) Read2() { var a = Read(); return (a[0], a[1]); }
        
        static void Main(string[] args)
        {
            var (right, testCount) = Read2();
            FieldPart treeHead = null;

            for (var i = 0; i < testCount; i++)
            {
                var zeroNo = int.Parse(Console.ReadLine()!);
                if (treeHead == null)
                {
                    Console.WriteLine($"? {1} {right}");
                    treeHead = new FieldPart
                    {
                        LeftEdge = 1,
                        RightEdge = right,
                        ZeroCount = right - int.Parse(Console.ReadLine()!)
                    };
                }
                var tree = treeHead;
                while (tree.LeftEdge < tree.RightEdge)
                {
                    if (tree.LeftSubPart == null)
                        FillSubParts(tree);

                    tree.ZeroCount--;
                    if (tree.LeftSubPart!.ZeroCount >= zeroNo)
                    {
                        tree = tree.LeftSubPart;
                    }
                    else
                    {
                        zeroNo -= tree.LeftSubPart.ZeroCount;
                        tree = tree.RightSubPart;
                    }
                }

                tree.ZeroCount--;
                Console.WriteLine($"! {tree.LeftEdge}");
            }
        }
        
        private static void FillSubParts(FieldPart fieldPart) 
        {
            var middle = (fieldPart.LeftEdge + fieldPart.RightEdge) / 2;
            Console.WriteLine($"? {fieldPart.LeftEdge} {middle}");
            var elementSum = int.Parse(Console.ReadLine()!);
            fieldPart.LeftSubPart = new FieldPart{
                LeftEdge = fieldPart.LeftEdge,
                RightEdge = middle,
                ZeroCount = middle - fieldPart.LeftEdge + 1 - elementSum
            };
            fieldPart.RightSubPart = new FieldPart {
                LeftEdge = middle + 1,
                RightEdge = fieldPart.RightEdge,
                ZeroCount = fieldPart.ZeroCount - fieldPart.LeftSubPart.ZeroCount
            };
        }
        
        public class FieldPart
        {
            public int LeftEdge {get; set;}
            public int RightEdge {get; set;}
            public int ZeroCount {get; set;}
            public FieldPart LeftSubPart {get; set;}
            public FieldPart RightSubPart {get; set;}
        }
    }
}