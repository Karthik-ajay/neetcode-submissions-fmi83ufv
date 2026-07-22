public class Solution {
    public int Trap(int[] height) {
        int[] maxToLeft = new int[height.Length];
        int[] maxToRight = new int[height.Length];
        int sum = 0;

        int maxR = 0;
        int maxL = 0;

        for (int i = 0; i < height.Length; i++)
        {
            maxToLeft[i] = maxL;
            maxL = Math.Max(maxL, height[i]);

            maxToRight[height.Length - i - 1] = maxR;
            maxR = Math.Max(maxR, height[height.Length - i - 1]);
        }

        for (int i = 0; i < height.Length; i++)
        {
            sum += (Math.Min(maxToLeft[i], maxToRight[i]) - height[i]) > 0 ? (Math.Min(maxToLeft[i], maxToRight[i]) - height[i]) : 0;
        }

        return sum;
    }
}
