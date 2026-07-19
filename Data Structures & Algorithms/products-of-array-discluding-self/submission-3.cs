public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        var postfix = new int[nums.Length];
        var result = new int[nums.Length];

        Array.Fill(prefix, 1);
        Array.Fill(postfix, 1);

        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1];
            postfix[nums.Length - i - 1] = postfix[nums.Length - i] * nums[nums.Length - i]; 
        }

        for (int i = 0; i < nums.Length; i++)
            result[i] = prefix[i] * postfix[i];

        return result;

    }
}
