public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> seenNums = new();
        for(int i = 0; i < nums.Length; i++)
        {
            if(!seenNums.Add(nums[i]))
            {
                return true;
            }
        }
        return false;
    }
}