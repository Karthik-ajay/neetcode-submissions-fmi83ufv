public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int left = 0;
        int right = s.Length - 1;
        int max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (set.Contains(s[i]))
            {
                while (set.Contains(s[i]))
                    set.Remove(s[left++]);
                
            }
            
            set.Add(s[i]);
            max = Math.Max(set.Count, max);
        }

        return max;
    }
}
