public class Solution {
    static Dictionary<char, int> values = new() {
        {'M', 1000},
        {'D', 500},
         {'C', 100},
         {'L', 50},
         {'X', 10},
         {'V', 5},
        {'I', 1}
    };
    public int RomanToInt(string s) {
        char lastSymbol = s[s.Length - 1];
        int lastValue = values[lastSymbol];
        int total = lastValue;
        
        for(int i = s.Length - 2; i >= 0; i--)
        {
            char curr = s[i];
            int currValue = values[curr];
            if(currValue < lastValue)
            {
                total -= currValue;
            }
            else
            {
                total += currValue;
            }
            lastValue = currValue;
        }
        return total;
    }
}