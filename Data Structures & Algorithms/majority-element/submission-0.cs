public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }
        return freq.MaxBy(x => x.Value).Key;
    }
}