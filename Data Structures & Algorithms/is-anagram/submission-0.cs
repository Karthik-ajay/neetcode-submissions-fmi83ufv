public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] chars = new int[26];
        foreach (char c in s)
            chars[c - 'a']++;
        foreach (char c in t)
            chars[c - 'a']--;
        return !chars.Any(x => x != 0);
    }
}
