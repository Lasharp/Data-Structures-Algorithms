# Rotate Array – My Learning Journey

**Problem:** Rotate an array to the right by `k` steps, in-place.

---

## My Exploration

1. **Brute Force** – shift elements one by one. ✅ Works, ❌ Too slow for large arrays.  

2. **Reverse Algorithm – Genius Insight**  
- Insight: Array rotation can be achieved by **reversing the array in parts**.  
- Steps:  
  1. Reverse the whole array.  
  2. Reverse the first k elements.  
  3. Reverse the remaining n-k elements.  

- ✅ Time: O(n), ✅ Space: O(1)  
- Works elegantly for any array size or rotation count.

---

**Why it’s brilliant:**  
- No extra space, linear time, and incredibly clean.  
- The rotation “emerges naturally” from three simple reversals — a perfect example of **finding hidden patterns**.  

---

**Takeaway:**  
Some problems hide **beautiful, almost magical solutions** that transform a messy task into something simple and efficient. Recognizing these patterns is the key to thinking like a true problem solver.
