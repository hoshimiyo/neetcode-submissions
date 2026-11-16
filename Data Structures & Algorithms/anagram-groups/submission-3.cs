public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (var s in strs) {
            var counts = new int[26];
            foreach (var c in s) counts[c - 'a']++;

            var key = string.Join(",", counts);  // e.g. "1,0,0,0,1,...,1,..."

            if (!map.TryGetValue(key, out var list)) {
                list = new List<string>();
                map[key] = list;
            }
            list.Add(s);
        }

        return map.Values.ToList();
    }
}
