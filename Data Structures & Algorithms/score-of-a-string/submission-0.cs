public class Solution {
    public int ScoreOfString(string s) {
        int result = 0;
        for (int i = 1; i < s.Length; i++)
        {
            int x = s[i];
            int y = s[i - 1];
            result = result + Math.Abs(x - y);
        }

        return result;
    }
}