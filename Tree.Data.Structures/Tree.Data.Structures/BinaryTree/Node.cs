namespace Tree.Data.Structures.BinaryTree
{
    public class Node(string value)
    {
        public string Value { get; set; } = value;

        public Node? Left { get; set; }

        public Node? Right { get; set; }
    }
}
