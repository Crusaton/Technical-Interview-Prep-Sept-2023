public class Solution {
    public bool IsPalindrome(string s) {
        string cleaned = new string(s.Where(Char.IsLetterOrDigit).ToArray()).ToLower();
        
        for(int i = 0; i < cleaned.Length; i++)
        {
            if(cleaned[i] != cleaned[cleaned.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}