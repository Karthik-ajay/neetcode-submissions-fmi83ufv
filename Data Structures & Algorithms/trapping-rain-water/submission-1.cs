public class Solution {
    public int Trap(int[] height) {
        int maxR = 0;
        int maxL = 0;

        int total = 0;

        int l = 0;
        int r = height.Length - 1;

        while (l < r)
        {
            if (height[l] < height[r])
            {
                maxL = Math.Max(maxL, height[l]);
                total += maxL - height[l];
                l++;
            }
            else
            {
                maxR = Math.Max(maxR, height[r]);
                total += maxR - height[r];
                r--;
            }
        }

        return total;
    }
}
