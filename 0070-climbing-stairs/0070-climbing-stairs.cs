public class Solution {
    public int ClimbStairs(int n) {
        
        
        // This is a fibonacci sequence. We wanted to add the two previous values.
        // We start one and two at 1 because its just the beginning two numbers we can start with.
        // So for n = 2 we know there are only two ways we can get to the top. We can either take one step twice, or two steps once.
        // If we set both our initial values of our fibonacci sequence to one we will get two on the only iteration and be done. 
        // But if we have a greater value of n such as 5 then the sequence will work like a typical fibonacci sequence
        // 
        // i = 0 -> one = 2, two = 1
        // i = 1 -> one = 3, two = 2
        // i = 2 -> one = 5, two = 3 
        // i = 3 -> one = 8, two = 5
        // i = 4 -> one = 13, two = 8
        int one = 1;
        int two = 1;
        
        // We iterate from 0 up to n - 1 so we don't overstep.
        for(int i = 0; i < n - 1; i++)
        {
            // We want to save one's value.
            int temp = one;
            // We add up our previous two numbers and set one to that new number.
            one = one + two;
            // We set two to our previous one value to continue the sequence.
            two = temp;
        }
        return one;
    }
}