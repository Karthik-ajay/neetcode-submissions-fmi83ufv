public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var sb = new StringBuilder();
        int minLen = strs.Min(x => x.Length);
        for (int i = 0; i < minLen; i++)
        {
            var currChar = strs[0][i];
            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j][i] != currChar)
                    return sb.ToString();
                if (j == strs.Length - 1)
                    sb.Append(currChar);
            }
        }
        return sb.ToString();
    }
}