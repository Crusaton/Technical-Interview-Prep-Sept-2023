public class Solution {
    public int SingleNumber(int[] nums) {
        
        if(nums.Length == 1)
        {
            return nums[0];
        }
        int result = 0;
        
        foreach(int num in nums)
        {
            result ^= num;
        }
        return result;
    }
}