public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        // Time Complexity: O(n) because we only iterate over the array once and the time will linearly scale based on the size of the input array.
        // Space Complexity: O(n) because the size of our hashmap will scale based on the size of the input array.
        
        // Dictionary/HashMap to track the numbers we've seen and their indices
        Dictionary<int, int> seenNums = new();
        
        // Iterate through the list of numbers provided.
        for(int i = 0; i < nums.Length; i++)
        {
            // Calculate the number we need to check to see if we've seen.
            int remainder = target - nums[i];
            // Check to see if we've seen that number.
            if(seenNums.ContainsKey(remainder))
            {
                // If we have we are done, return the array containing both indices.
                return new int[2] { seenNums[remainder], i };
            }
            // If we haven't seen the remainder number, we add the current index and its value.
            else if(!seenNums.ContainsKey(nums[i]))
            {
                seenNums.Add(nums[i], i);
            }
        }
        return null;
    }
}