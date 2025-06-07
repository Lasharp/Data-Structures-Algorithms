
namespace InsertionSort.Algorithm
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            List<int> numbers = [5, 8, 2, 1, 9, 4];

            // Printing numbers before sorting
            Console.WriteLine("Before sorting");
            PrintNumbers(numbers);

            // Make sorting
            numbers.InsertionSort();

            // Print numbers after sorting
            Console.WriteLine();
            Console.WriteLine("After sorting");
            PrintNumbers(numbers);
        }

        private static void PrintNumbers(List<int> collection)
        {
            foreach (int number in collection)
            {
                Console.Write(number + " ");
            }
        }
    }
}
