public class Solution {
    public bool IsPalindrome(string s) {
        string n = String.Concat(Array.FindAll(s.ToCharArray(), Char.IsLetterOrDigit));
        n = n.ToLower();
        for(int i = 0; i < n.Length; i++)
        {
            if(n[i] != n[n.Length - (i + 1)])
            {
                return false;
            }
        }
        return true;
    }
}