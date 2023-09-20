public class Solution {
    public int SingleNumber(int[] nums) {
        
        if(nums.Count() == 1)
        {
            return nums[0];
        }
        
        int result = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            result ^=nums[i];
        }
        return result;
    }
}