namespace Tree.Data.Structures.Tree
{
    public class Node
    {
        public required int Id { get; set; }
        public required string Content { get; set; }
        public required ICollection<Node> Children { get; set; }
    }
}
