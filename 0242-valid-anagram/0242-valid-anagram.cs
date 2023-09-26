public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length)
        {
            return false; 
        }
        
        int[] seenChars = new int[26];
        
        for(int i = 0; i < s.Length; i++)
        {
            seenChars[s[i] - 'a']++;
        }
        for(int i = 0; i < t.Length; i++)
        {
            if(seenChars[t[i] - 'a'] == null || seenChars[t[i] - 'a'] <= 0)
            {
                return false;
            }
            seenChars[t[i] - 'a']--;
        }
        return true;
    }
}