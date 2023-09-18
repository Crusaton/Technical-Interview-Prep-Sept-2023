public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        // Can use a hashset since we only want unique values
        HashSet<int> seenNums = new();
        
        
        // Loop through dataset
        foreach(int num in nums)
        {
            // If we can't add the value we know we've found a duplicate.
            if(!seenNums.Add(num))
            {
                return true;
            }
        }
        return false;
    }
}