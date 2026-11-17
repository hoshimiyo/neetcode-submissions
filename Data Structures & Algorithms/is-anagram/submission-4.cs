public class Solution {
    public bool IsAnagram(string s, string t) {
        var dict = new Dictionary<char, int>();

        foreach (char c in s) {
            if (!dict.ContainsKey(c)) {
                dict[c] = 1;
            } else {
                dict[c]++;
            }
        }

        foreach (char c in t) {
            if (!dict.ContainsKey(c)) {
                return false;
            } else {
                dict[c]--;
            }
        }

        foreach(var kvp in dict){
            if(kvp.Value != 0){
                return false;
            }
        }

        return true;
    }
}
