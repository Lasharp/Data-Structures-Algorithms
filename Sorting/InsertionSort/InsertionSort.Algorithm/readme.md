# 🧠 Insertion Sort — So Simple, It's Genius!

## ✨ Imagine This:

You're holding a deck of playing cards. You take the first card — easy.  
Then you take another card and place it **in the right position** next to the first.  
Then another, and another... each time, you **slide** cards over until the new one fits.

🎯 That’s **Insertion Sort** — sorting like a human!

---

## 🔍 Why It’s Cool

- It’s one of the most **intuitive sorting algorithms**.
- It doesn’t require any fancy data structures.
- You sort the array by building up the correct order **one item at a time**.
- You don't throw everything up in the air — just keep the left side sorted!

---

## 📈 Time Complexities (Big O)

| Case           | Comparisons / Shifts | Big-O     |
|----------------|----------------------|-----------|
| Best (sorted)  | Only comparisons     | O(n)      |
| Average        | Some shifting        | O(n²)     |
| Worst (reversed) | Full shifting      | O(n²)     |
| Space          | In-place (no extra)  | O(1)      |

👉 It’s **fast** for small or nearly sorted data, but **slow** for large random data.

---

## 🧩 How It Works (Step-by-Step)

```csharp
public static class InsertionSorting
{
    public static void InsertionSort(this List<int> collection)
    {
        for (int i = 1; i < collection.Count; i++) // Start at index 1
        {
            int value = collection[i];            // Take the current card
            int leftMostSortedIndex = i - 1;      // Look at the left (already sorted)

            while (leftMostSortedIndex >= 0 && collection[leftMostSortedIndex] > value)
            {
                collection[leftMostSortedIndex + 1] = collection[leftMostSortedIndex]; // Shift right
                leftMostSortedIndex--; // Move left
            }

            collection[leftMostSortedIndex + 1] = value; // Place the card in the right spot
        }
    }
}
```

📘 Want to learn when to use which sorting algorithm?  
Check out the [Sorting Algorithm Trade-offs](./trade-offs.md)