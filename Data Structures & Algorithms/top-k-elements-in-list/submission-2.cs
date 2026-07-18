public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new ();
        foreach (var num in nums)
        {
            if (!freq.ContainsKey(num))
                freq.Add(num, 0);
            freq[num]++;
        }

        PriorityQueue<int, int> pq = new();
        foreach (var kvp in freq)
        {
            pq.Enqueue(kvp.Key, kvp.Value);
            if (pq.Count > k)
                pq.Dequeue();
        }

        int[] result = new int[k];
        for (int i = 0; i < k; i++)
            result[i] = pq.Dequeue();
        
        return result;
    }
}
