public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var result = new int[nums.Length * 2];
        int k = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[i + k] = nums[i];
        }
        return result;
    }
}