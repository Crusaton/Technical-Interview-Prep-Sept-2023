using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        s = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty);
        s = s.ToLower();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i]!= s[s.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}