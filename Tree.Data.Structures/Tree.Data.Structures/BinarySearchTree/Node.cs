namespace Tree.Data.Structures.BinarySearchTree
{
    public class Node(int value)
    {
        public int Value { get; set; } = value;

        public Node? Left { get; set; }

        public Node? Right { get; set; }
    }
}
