public class Solution {
    public bool IsSubsequence(string s, string t) {
        int substringIndex = 0;
        if (s.Length == 0)
            return true;
        for (int i = 0; i < t.Length; i++)
        {
            if (s[substringIndex] == t[i])
                substringIndex++;
            if (substringIndex == s.Length)
                return true;
        }
        return false;
    }
}