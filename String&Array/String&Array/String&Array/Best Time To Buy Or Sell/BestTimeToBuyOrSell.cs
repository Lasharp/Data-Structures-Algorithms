namespace String_Array.Best_Time_To_Buy_Or_Sell
{
    public class BestTimeToBuyOrSell
    {
        public static int MaxProfit(int[] prices)
        {
            int price = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < price)
                {
                    price = prices[i];
                }
                if (maxProfit < prices[i] - price)
                {
                    maxProfit = prices[i] - price;
                }
            }

            return maxProfit;
        }
    }
}
