# Best Time to Buy and Sell Stock II – My Learning Journey

**Problem:** Given an array of stock prices, maximize profit by **buying and selling multiple times**. You must sell before buying again.

---

## My Exploration

1. **Observation:** Profit is made whenever a price rises from one day to the next.  
2. **Genius Insight (One-Pass):**  
   - Iterate through the array.  
   - Every time `prices[i] > prices[i-1]`, **capture the difference** as profit.  
   - Sum all these increments → maximum profit.  

- ✅ Time: O(n), ✅ Space: O(1)  
- Works in a single pass, no extra storage, fully in-place.

---

**Why it feels “easy”:**  
- The problem is labeled Medium because some might try **complex DP approaches** first.  
- Once you notice **profit comes from every small rise**, it reduces to a simple **greedy accumulation** problem.  
- Shows the power of **pattern recognition**: the complexity vanishes when you see the underlying property.

---

**Takeaway:**  
Many “medium” problems hide **simple truths**. The challenge isn’t coding; it’s **seeing the right insight** that turns O(n²) or DP into a one-pass O(n) solution.
