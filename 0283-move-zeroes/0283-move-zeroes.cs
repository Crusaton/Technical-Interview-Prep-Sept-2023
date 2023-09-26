public class Solution {
    public void MoveZeroes(int[] nums) {
        
        // Two pointer approach
        int readIndex = 0;
        int writeIndex = 0;
        
        // While we haven't hit the end of the array. (While we are still reading values)
        while (readIndex < nums.Length)
        {
            // If we encounter a 0
            if(nums[readIndex] == 0)
            {
                // Increment our read index one and continue
                readIndex++;
                continue;
            }
            // Now that we encountered a 0 our indices don't match
            if(readIndex != writeIndex)
            {
                // Set the writeIndex value to the postion in front of it.
                nums[writeIndex] = nums[readIndex];
                // Move the 0 towards the end of the list.
                nums[readIndex] = 0;
            }
            // Increment both our indices
            writeIndex++;
            readIndex++;
        }
    }
}