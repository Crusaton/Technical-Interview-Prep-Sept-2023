public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int min = prices[0];
        
        for(int i = 0; i < prices.Length; i++)
        {
            int curr = prices[i];
            min = Math.Min(min, curr);
            maxProfit = Math.Max(maxProfit, curr - min);
        }
        return maxProfit;
    }
}