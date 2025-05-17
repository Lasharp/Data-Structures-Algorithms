namespace Tree.Data.Structures.BinarySearchTree
{
    public class Node
    {
        public required string ProductName { get; set; }
        public required decimal ProductPrice { get; set; }
        public  Node? Left { get; set; }
        public  Node? Right { get; set; }
    }
}
