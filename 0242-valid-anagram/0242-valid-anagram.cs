public class Solution {
    public bool IsAnagram(string s, string t) {
        
        int[] freq = new int[26];
        
        foreach(char c in s)
        {
            freq[c - 'a']++;
        }
        foreach(char c in t)
        {
            freq[c -'a']--;
        }
        foreach(int c in freq)
        {
            if(c != 0)
            {
                return false;
            }
        }
        return true;
    }
}