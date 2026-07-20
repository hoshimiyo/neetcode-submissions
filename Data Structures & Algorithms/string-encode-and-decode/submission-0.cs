public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0)
            return "";
            
        List<int> sizes = new List<int>();
        StringBuilder resString = new StringBuilder();
        foreach(string s in strs)
        {
            sizes.Add(s.Length);
        }
        foreach(int sz in sizes)
        {
            resString.Append(sz).Append(',');
        }
        resString.Append('#');
        foreach(string s in strs)
        {
            resString.Append(s);
        }
        return resString.ToString();
    }

    public List<string> Decode(string s) {
        if(s.Length == 0)
        {
            return new List<string>();
        }
        List<int> sizes = new List<int>();
        List<string> resString = new List<string>();
        int i = 0;
        while(s[i] != '#')
        {
            int j = i;
            while(s[j] != ',')
            {
                j++;
            }
            sizes.Add(int.Parse(s.Substring(i, j - i)));
            i = j + 1;
        }
        i++;
        foreach (int sz in sizes) {
            resString.Add(s.Substring(i, sz));
            i += sz;
        }
        return resString;
   }
}
