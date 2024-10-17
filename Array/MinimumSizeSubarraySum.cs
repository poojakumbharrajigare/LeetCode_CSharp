/*
Given an array of positive integers nums and a positive integer target, return the minimal length of a 
subarray whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.
*/

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int start = 0;
        int len = Int32.MaxValue;
        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            while (sum >= target)
            {
                len = Math.Min(len, i - start + 1);
                sum -= nums[start];
                start++;
            }
        }

        return len == Int32.MaxValue ? 0: len;
    }
}