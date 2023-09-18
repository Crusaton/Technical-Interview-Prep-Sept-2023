public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        int[] magazineChars = new int[26];
        
        foreach(char c in magazine)
        {
            magazineChars[c - 'a']++;
        }
        foreach(char c in ransomNote)
        {
            magazineChars[c - 'a']--;
            if(magazineChars[c - 'a'] < 0)
            {
                return false;
            }
        }
        return true;
    }
}