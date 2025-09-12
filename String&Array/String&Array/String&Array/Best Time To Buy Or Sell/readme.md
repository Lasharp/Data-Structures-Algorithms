# Best Time to Buy and Sell Stock – My Learning Journey

**Problem:** Given an array of stock prices, find the maximum profit from **one buy and one sell**.

---

## My Exploration

1. **Brute Force** – check all pairs of buy/sell days. ✅ Works, ❌ Too slow (O(n²)).  

2. **Optimized Linear Approach – Genius Insight**  
- Insight: To maximize profit, **track the lowest price seen so far** while iterating.  
- At each day, calculate potential profit as `current price - minimum price so far`.  
- Update maximum profit whenever this potential profit is higher.  

- ✅ Time: O(n), ✅ Space: O(1)  
- Works in a single pass and elegantly handles all scenarios.

---

**Why it’s brilliant:**  
- No extra arrays, no nested loops — just a single sweep through the prices.  
- Turns a seemingly complex problem into a **simple, intuitive observation**: keep track of the minimum and compute profit on the fly.  
- Shows the power of **recognizing patterns in sequences** rather than brute-forcing everything.

---

**Takeaway:**  
Sometimes the smartest solutions come from **observing the right property** in the data. A small insight can transform O(n²) work into O(n) elegance.
