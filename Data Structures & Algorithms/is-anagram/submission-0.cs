public class Solution {
    public bool IsAnagram(string s, string t) {
        string s1 = String.Concat(s.OrderBy(c => c));
        string t1 = String.Concat(t.OrderBy(c => c));
        if (s1 == t1) return true;
         return false;
    }
}
