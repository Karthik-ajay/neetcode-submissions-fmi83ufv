public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();
        foreach(var num in nums)
        {
            if (!freqMap.ContainsKey(num))
                freqMap[num] = 0;
            freqMap[num]++;
        }
        return freqMap
                .OrderByDescending(x => x.Value)
                .Take(k)
                .Select(x => x.Key)
                .ToArray();
    }
}
