public class Solution {
    public bool IsPalindrome(string s) {
        
        StringBuilder sb = new();
        
        foreach(char c in s)
        {
            if((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
            {
                sb.Append(Char.ToLower(c));
            }
        }
        
        string temp = sb.ToString();
        
        for(int i = 0; i < temp.Length; i++)
        {
            if(temp[i] != temp[temp.Length - i - 1])
            {
                return false;
            }
        }
        return true;
        
    }
}