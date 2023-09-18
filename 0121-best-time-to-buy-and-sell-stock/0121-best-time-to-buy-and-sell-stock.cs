public class Solution {
    public int MaxProfit(int[] prices) {
        
        int maxProfit = 0;
        int min = Int32.MaxValue;
        
        for(int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            int currProfit = prices[i] - min;
            maxProfit = Math.Max(maxProfit, currProfit);
        }
        
        return maxProfit;
    }
}