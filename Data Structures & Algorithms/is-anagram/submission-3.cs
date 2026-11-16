public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char c in s) {
            if (dict.ContainsKey(c)) {
                dict[c]++;
            } else {
                dict[c] = 1;
            }
        }

        foreach (char c in t) {
            if (dict.ContainsKey(c)) {
                dict[c]--;
            } else {
                return false;
            }
        }

        foreach (var kvp in dict) {
            if (kvp.Value != 0) {
                return false;
            }
        }

        return true;
    }
}
