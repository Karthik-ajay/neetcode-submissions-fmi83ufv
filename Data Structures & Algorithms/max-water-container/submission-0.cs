public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right)
        {
            int currArea = 0;
            if (heights[right] < heights[left])
                currArea = (right - left) * heights[right--];
            else
                currArea = (right - left) * heights[left++];
            maxArea = Math.Max(currArea, maxArea);
        }
        return maxArea;
    }
}
