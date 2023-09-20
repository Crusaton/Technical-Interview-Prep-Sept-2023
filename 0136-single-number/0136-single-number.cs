public class Solution {
    public int SingleNumber(int[] nums) {
        
        // If the array only has one item we found our answer.
        if(nums.Count() == 1)
        {
            return nums[0];
        }
        
        int result = 0;
        
        // Iterate through our array. 
        for(int i = 0; i < nums.Length; i++)
        {
            // Performing an XOR operation.
            // It basically turns the question into an equation doing this.
            // If nums = [4,1,2,1,2]
            // ((2^2)^(1^1)^(4)) = (0^0^4)
            result ^=nums[i];
        }
        return result;
    }
}