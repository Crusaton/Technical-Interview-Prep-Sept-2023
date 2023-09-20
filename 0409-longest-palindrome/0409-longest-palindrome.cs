public class Solution {
    public int LongestPalindrome(string s) {
        
        // Checking for edge cases of the string is null/empty or it is only one character.
        if(s == null || s.Length == 0)
        {
            return 0;
        }
        else if(s.Length == 1)
        {
            return 1;
        }
        
        HashSet<char> hs = new();
        int count = 0;
        
        // Loop through the string and visit each char
        for(int i = 0; i < s.Length; i++)
        {
            // If we've seen this character before, remove it and increment our counter.
            if(hs.Contains(s[i]))
            {
                hs.Remove(s[i]);
                count++;
            }
            // If we haven't seen it we add it to our hashset.
            else
            {
                hs.Add(s[i]);
            }
        }
        // If we still have some remaining in our hashset we know that we had an uneven number of that char, but for a palindrome we can only have one extra char so we only increment 1.
        if(hs.Count > 0)
        {
            return count * 2 + 1;
        }
        return count * 2;
    }
}