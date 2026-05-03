public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int currCount = 0;
        int maxCount = 0;
        foreach (int num in nums)
        {
            if (num != 1)
                currCount = 0;
            else
                currCount++;
            maxCount = currCount > maxCount ? currCount : maxCount;
        }
        return maxCount;
    }
}