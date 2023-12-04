public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seenNums = new();
        
        for(int i = 0; i < nums.Length; i++)
        {
            int remainder = target - nums[i];
            
            if(seenNums.ContainsKey(remainder))
            {
                return new int[2] { seenNums[remainder], i };
            }
            else
            {
                seenNums.TryAdd(nums[i], i);
            }
        }
        return null;
    }
}