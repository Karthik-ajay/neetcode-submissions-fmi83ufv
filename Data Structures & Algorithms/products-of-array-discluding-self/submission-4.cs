public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        result[0] = 1;

        int prefix = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            prefix = prefix * nums[i - 1];
            result[i] = prefix;
        }

        int suffix = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            suffix = suffix * nums[i + 1];
            result[i] = result[i] * suffix;
        }

        return result;
    }
}
