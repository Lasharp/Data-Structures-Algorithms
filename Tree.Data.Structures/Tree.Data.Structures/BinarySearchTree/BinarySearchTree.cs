namespace Tree.Data.Structures.BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node? Root { get; private set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            var newNode = new Node(value);

            if (Root is null)
            {
                Root = newNode;
                return;
            }

            Node? current = Root;
            while (current is not null)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        break;
                    }
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        break;
                    }
                    current = current.Right;
                }
                else
                {
                    current = null;
                }
            }
        }
    }
}
