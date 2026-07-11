public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        Dictionary<char,int> sString = new Dictionary<char,int>();
        Dictionary<char,int> tString = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++)
        {
            sString[s[i]] = sString.GetValueOrDefault(s[i], 0) + 1;
            tString[t[i]] = tString.GetValueOrDefault(t[i], 0) + 1;
        }
        return sString.Count == tString.Count && !sString.Except(tString).Any();
    }
}
