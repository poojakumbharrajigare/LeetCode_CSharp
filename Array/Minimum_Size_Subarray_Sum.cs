/*
Given an array of positive integers nums and a positive integer target, return the minimal length of a 
subarray
 whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.
 */

 public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length;
        int left = 0, right = 0;
        int currentSum = 0;
        int minLength = int.MaxValue;

        while (right < n) {
            // Expand the window by adding the element at right
            currentSum += nums[right];
            right++;

            // While the current window's sum is greater than or equal to target, try to shrink the window
            while (currentSum >= target) {
                minLength = Math.Min(minLength, right - left);
                currentSum -= nums[left];
                left++;
            }
        }

        // If minLength was updated, return it; otherwise, return 0
        return minLength == int.MaxValue ? 0 : minLength;
    }
}