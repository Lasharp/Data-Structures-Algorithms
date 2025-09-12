# Jump Game – My Learning Journey

**Problem:** Given an array where each element represents the maximum jump length from that position, determine if you can reach the last index.

---

## My Exploration

1. **Brute Force / DFS** – try every possible jump recursively. ✅ Works, ❌ Too slow (exponential time).  

2. **Greedy Backward Approach – Genius Insight**  
- Insight: Instead of jumping forward, **work backwards from the last index**.  
- Track the **earliest index that can reach the end**.  
- Iterate from right to left:  
  - If `i + nums[i]` reaches or passes the current target, update the target to `i`.  
- If the target reaches index 0 → success.

- ✅ Time: O(n), ✅ Space: O(1)  
- Elegant single-pass solution without recursion or extra storage.

---

**Why it’s brilliant:**  
- Turns a seemingly complex forward exploration problem into a **simple backward scan**.  
- Relies purely on **logical reasoning about reachability**, not brute force.  
- Shows how a small shift in perspective can reduce **exponential work to linear**.

---

**Takeaway:**  
Some problems aren’t about fancy data structures — they’re about **changing your perspective**. Recognizing the right angle can make the impossible simple.
