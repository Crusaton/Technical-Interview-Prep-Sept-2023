public class Solution {
    public int LongestPalindrome(string s) {
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
        
        for(int i = 0; i < s.Length; i++)
        {
            if(hs.Contains(s[i]))
            {
                hs.Remove(s[i]);
                count++;
            }
            else
            {
                hs.Add(s[i]);
            }
        }
        if(hs.Count > 0)
        {
            return count * 2 + 1;
        }
        return count * 2;
    }
}