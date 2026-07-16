public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> set = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (set.ContainsKey(target - nums[i]))
                return new int[]{set[target - nums[i]], i};
            set.Add(nums[i], i);
        }
        return new int[2];
    }
}
