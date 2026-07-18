public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> set = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            char[] temp = str.ToArray();
            Array.Sort(temp);
            string key = new String(temp);
            if (!set.ContainsKey(key))
                set.Add(key, new List<string>());
            set[key].Add(str);
        }
        return set.Values.ToList();
    }
}
