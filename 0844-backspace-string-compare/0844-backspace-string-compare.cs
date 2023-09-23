public class Solution {
    public bool BackspaceCompare(string s, string t) {
        int i = s.Length - 1;
        int j = t.Length - 1;
        int skipS = 0;
        int skipT = 0;
        while(i >= 0 || j >= 0)
        {
            // While we haven't hit the end of the string S.
            while(i >= 0)
            {
                // If we hit a backspace character
                if(s[i] == '#')
                {
                    // We increment the skip counter and decrease the iterator I
                    skipS++; i--;
                }
                // Else if we didn't hit a backsapce character but the character before it is
                else if(skipS > 0)
                {
                    // We decrease both iterators
                    skipS--; i--;
                }
                else
                {
                    // We haven't hit any backspace character so we break the loop.
                    break;
                }
            }
            // While we haven't hit the end of the string T.
            while(j >= 0)
            {
                // If we found a backspace character 
                if(t[j] == '#')
                {
                    // We increment the counter of what we skip and decrease the iterator J.
                    skipT++; j--;
                }
                // If 
                else if (skipT > 0 )
                {
                    skipT--; j--;
                }
                else
                {
                    break;
                }
            }
            if(i >= 0 && j >= 0 && s[i] != t[j])
            {
                return false;
            }
            if((i >= 0) != (j >= 0))
            {
                return false;
            }
            i--; j--;
        }
        return true;
    }
}