public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var charArr = str.ToCharArray();
            Array.Sort(charArr);
            var newStr = new String(charArr);
            if (!result.ContainsKey(newStr))
                result.Add(newStr, new List<string>());
            result[newStr].Add(str);
        }
        return result.Values.ToList();
    }
}
