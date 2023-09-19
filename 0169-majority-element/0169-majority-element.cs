public class Solution {
    public int MajorityElement(int[] nums) {
        
        Dictionary<int, int> seenNums = new();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(seenNums.ContainsKey(nums[i]))
            {
                seenNums[nums[i]]++;
            }
            else
            {
                seenNums.Add(nums[i], 1);
            }
        }
        int greatestSeen = 0;
        int val = 0;
        foreach(var entry in seenNums)
        {
            if(entry.Value > greatestSeen)
            {
                greatestSeen = entry.Value;
                val = entry.Key;
            }
        }
        return val;
    }
}