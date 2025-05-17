namespace Tree.Data.Structures.BinaryTree
{
    public class Node
    {
        public required string ProductName { get; set; }
        public required decimal ProductPrice { get; set; }
        public required Node Left { get; set; }
        public required Node Right { get; set; }
    }
}
