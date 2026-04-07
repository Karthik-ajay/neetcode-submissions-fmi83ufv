public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();
        foreach(var str in strs)
        {
            var charArr = str.ToCharArray();
            Array.Sort(charArr);
            var sortedStr = new string(charArr);
            if (!result.ContainsKey(sortedStr))
                result[sortedStr] = new List<string>();
            result[sortedStr].Add(str);
        }
        return result.Values.ToList<List<string>>();
    }
}
