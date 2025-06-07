namespace Tree.Data.Structures.BinaryTree
{
    public class AnimalGuesser
    {
        private readonly Node _root;

        public AnimalGuesser()
        {
            _root = new Node("Is it a mammal?");
            _root.Left = new Node("Is it bigger than a cat?");
            _root.Right = new Node("Is it a bird?");

            var leftNode = _root.Left;

            leftNode.Left = new Node("Dog");
            leftNode.Right = new Node("Elephant");

            var rightNode = _root.Right;
            rightNode.Left = new Node("Eagle");
            rightNode.Right = new Node("Lizard");
        }

        public void Play()
        {
            var current = _root;

            while (current.Left is not null && current.Right is not null)
            {
                Console.WriteLine(current.Value + " (yes/no)");
                var input = Console.ReadLine()?.Trim().ToLower();

                if (input?.Equals("yes", StringComparison.OrdinalIgnoreCase) ?? false)
                {
                    current = current.Left!;
                }
                else if (input?.Equals("no", StringComparison.OrdinalIgnoreCase) ?? false)
                {
                    current = current.Right!;
                }
                else
                {
                    Console.WriteLine("Please answer only with 'yes' or 'no'.");
                }
            }

            Console.WriteLine($"🎉 I think it's a {current.Value}!");
        }
    }
}
