public class Solution {
    public bool IsPalindrome(string s) {
        
        StringBuilder sb = new();
        foreach(var c in s)
        {
            if((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0') && c <= '9')
            {
                sb.Append(Char.ToLower(c));
            }
        }
        s = sb.ToString();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != s[s.Length - i - 1])
            {
                return false;
            }
        }
        return true;
        
    }
}