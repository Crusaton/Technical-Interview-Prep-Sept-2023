public class Solution {
    public bool IsAnagram(string s, string t) {
        
        int[] seenChars = new int[26];
        
        foreach(char c in s)
        {
            seenChars[c - 'a']++;
        }
        foreach(char c in t)
        {
            if(seenChars[c - 'a'] <= 0)
            {
                return false;
            }
            seenChars[c - 'a']--;
        }
        foreach(int i in seenChars)
        {
            if(i != 0)
            {
                return false;
            }
        }
        return true;
    }
}