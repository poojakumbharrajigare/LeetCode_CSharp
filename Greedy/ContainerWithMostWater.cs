/*
You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

Notice that you may not slant the container.
*/

public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;

        int maxArea = 0;

        while(left < right)
        {
            int width = right - left;
            int height = Math.Min(heights[left], heights[right]);
            int area = width * height;

            if(heights[left] < heights[right])
                left++;
            else
                right--;

            maxArea = Math.Max(area, maxArea);
        }

        return maxArea;
    }
}