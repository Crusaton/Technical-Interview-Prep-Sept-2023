public class Solution {
    public int MissingNumber(int[] nums) {
        /*
        int sum = 0;
        int total = nums.Length * (nums.Length + 1) / 2;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return total - sum;
        */
        
        
        
        /*
         XOR Method
         Thought process is that since we know the array will be between 0 and n and they are all unique
         So we can iterate through the array, and XOR our response variable with the iterator. 
         We then XOR response to the current index value in the array
         Example
            Input = [0, 2, 3]
            
            i = 0
            
                3 XOR 0 = 3 (response xor iterator value)
                3 XOR 0 = 3 (response xor index value in array)
            
            i = 1
                
                3 XOR 1 = 2 (response xor iterator value)
                2 XOR 2 = 0 (response xor index value in array)
                
            i = 2
            
                0 XOR 2 = 2 (response xor iterator value)
                2 XOR 3 = 1 (response xor index value in array)
                
            So our answer is 1.
            
            Memory Complexity = O(1) We only have to iterate through the input nums we did not require more space.
            Time Complexity = O(n) we only iterate through the input nums
        
        */
        int response = nums.Length;
        
        for(int i = 0; i < nums.Length; i++)
        {
            response ^= i;
            response ^= nums[i];
        }
        return response;
    }
}