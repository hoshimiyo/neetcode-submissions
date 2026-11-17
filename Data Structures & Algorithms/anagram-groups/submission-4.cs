public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach (string s in strs){
            char[] sArray = s.ToCharArray();
            Array.Sort(sArray);
            string sortedS = new string(sArray);
            if(!dict.ContainsKey(sortedS)){
                dict[sortedS] = new List<string>();
            }
            dict[sortedS].Add(s);
        }
        return dict.Values.ToList<List<string>>();
    }
}