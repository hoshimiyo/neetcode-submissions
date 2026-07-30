public class Solution {
    public bool IsPalindrome(string s) {
        string newString = "";
        foreach(char c in s){
            if(char.IsLetterOrDigit(c))
                newString += char.ToLower(c);
        }
        return newString == new String(newString.Reverse().ToArray());
    }
}
