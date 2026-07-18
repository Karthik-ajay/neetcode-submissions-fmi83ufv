public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!frequency.ContainsKey(num))
                frequency.Add(num, 0);
            frequency[num]++;
        }
        return frequency.OrderByDescending(x => x.Value)
                        .Select(x => x.Key)
                        .Take(k)
                        .ToArray();
    }
}
