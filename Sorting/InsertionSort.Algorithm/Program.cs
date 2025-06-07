
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
            InsertionSort(numbers);

            // Print numbers after sorting
            Console.WriteLine();
            Console.WriteLine("After sorting");
            PrintNumbers(numbers);
        }

        private static void InsertionSort(List<int> collection)
        {
            // First we need to create a loop, starting from 1, because logic inside, we use i - 1, so we don't go outside of range.
            for (int i = 1; i < collection.Count; i++)
            {
                int value = collection[i]; // Current value which we want to insert somewhere
                int leftMostSortedIndex = i - 1; // Last element index which we already sorted in the previous cycle

                // Logic, which works until it checks for first element if it is bigger, and if any of the value is more than our current value, it is going to shift right. 
                while (leftMostSortedIndex >= 0 && collection[leftMostSortedIndex].CompareTo(value) > 0)
                {
                    collection[leftMostSortedIndex + 1] = collection[leftMostSortedIndex]; // If we found value bigger than current, shift left value.
                    leftMostSortedIndex--; // Continue search value more than current on the left(sorted) side
                }

                collection[leftMostSortedIndex + 1] = value; // Finally insert the current value to where it belongs.
            }
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
