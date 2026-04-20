public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int prefix = 1;
        int suffix = 1;
        for (int i = 0; i < nums.Length; i++)
            result[i] = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            result[i] *= prefix;
            prefix *= nums[i];

            result[nums.Length - i - 1] *= suffix;
            suffix *= nums[nums.Length - i - 1];
        }
        return result;
    }
}
