public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        int[] magazineChars = new int[26];
        
        foreach(char c in magazine)
        {
            magazineChars[c - 'a']++;
        }
        foreach(char c in ransomNote)
        {
            if(magazineChars[c - 'a'] == 0)
            {
                return false;
            }
            magazineChars[c - 'a']--;
        }
        return true;
    }
}