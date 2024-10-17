/*
Given an integer array nums, find the subarray with the largest sum, and return its sum.
*/

public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = Int32.MinValue;
        int sum = 0;
        int n = nums.Length;

        for(int i = 0; i < n; i++)
        {
            sum += nums[i];
            maxSum = Math.Max(sum, maxSum);

            if(sum < 0)
            {
                sum = 0;
            }
        }

        return maxSum;
    }
}