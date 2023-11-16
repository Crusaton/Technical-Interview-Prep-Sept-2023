public class Solution {
    public int MaxProfit(int[] prices) {
        
        int min = prices[0];
        int max = 0;
        
        for(int i = 0; i < prices.Length; i++)
        {
            int currMin = prices[i];
            min = Math.Min(min, currMin);
            max = Math.Max(max, prices[i] - min);
        }
        return max;
    }
}