public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue;
        int max = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min)
                min = prices[i];
            max = Math.Max(prices[i] - min, max);
        }

        return max;
    }
}
