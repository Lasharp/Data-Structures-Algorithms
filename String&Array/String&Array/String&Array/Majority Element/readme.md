# Majority Element – My Learning Journey

**Problem:** Find the element in an array appearing more than ⌊n/2⌋ times. Assume it always exists.

---

## My Journey

1. **Brute Force** – check every element. ✅ Works, ❌ Too slow (O(n²))  
2. **HashMap Counting** – map value → count. ✅ Fast (O(n)), ❌ Uses extra space (O(n))  
3. **Boyer–Moore Voting Algorithm** – pure genius:

- Insight: **the majority element > n/2, so it can never be fully canceled out**.  
- Iterate once with a counter:  
  - Same as candidate → +1  
  - Different → -1  
  - Counter = 0 → pick new candidate  
- No extra space, linear time, and magically works **regardless of element order**.

---

**Why it’s mind-blowing:**  
- You don’t count every element, don’t store anything extra.  
- Just **pairwise canceling** exploits a hidden mathematical truth.  
- The array’s majority element literally “survives” all cancellations — it’s simple, elegant, and feels almost magical.  

---

**Takeaway:**  
Sometimes, the most powerful solutions aren’t about more computation — they’re about **seeing the hidden pattern no one else notices**.
