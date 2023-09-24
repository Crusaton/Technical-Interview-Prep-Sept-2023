public class Solution {
    
    // Hashmap/dictionary to have our roman letters and their respective decimal value.
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
        // Grab the last symbol of the string.
        char lastSymbol = s[s.Length - 1];
        // Grab the last symbol's value.
        int lastValue = values[lastSymbol];
        // Set our total to the last symbol's value.
        int total = lastValue;
        
        // We are iterating backwards from the end of the string.
        for(int i = s.Length - 2; i >= 0; i--)
        {
            // Grab the current symbol
            char curr = s[i];
            // Grab the current value
            int currValue = values[curr];
            // If our current value is less than the previous value we need to subtract
            // Similar to how IV works
            if(currValue < lastValue)
            {
                total -= currValue;
            }
            // Else if our currvalue is greater we can just add it
            else
            {
                total += currValue;
            }
            // Save curr as our previously seeen value.
            lastValue = currValue;
        }
        return total;
    }
}