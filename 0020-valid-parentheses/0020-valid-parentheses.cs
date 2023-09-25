public class Solution {
    public bool IsValid(string s) {
        Stack<char> curr = new();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                curr.Push(')');
            }
            else if(s[i] == '{')
            {
                curr.Push('}');
            }
            else if(s[i] == '[')
            {
                curr.Push(']');
            }
            else if(curr.Count() == 0 || curr.Pop() != s[i])
            {
                return false;
            }
        }
        return curr.Count() == 0;
    }
}