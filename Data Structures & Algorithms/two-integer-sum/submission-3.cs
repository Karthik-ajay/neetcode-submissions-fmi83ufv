public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i = 0, j = 1;
        while (i < j && j < nums.Length)
        {
            if (nums[i] + nums[j] == target)
                return new int[]{i, j};
            if (j == nums.Length - 1)
            {
                i++;
                j = i + 1;
            }
            else 
                j++;
        }
        return new int[2];
    }
}
