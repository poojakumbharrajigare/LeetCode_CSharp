/*
Given an integer array nums, find a  subarray that has the largest product, and return the product.

The test cases are generated so that the answer will fit in a 32-bit integer.
*/

public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums.Length == 0) 
            return 0;
        int max = nums[0];
        int min = nums[0];
        int res = nums[0];
        
        for (int i = 1; i < nums.Length; i++) 
        {
            if (nums[i] < 0) 
            {
                int t = max;
                max = min;
                min = t;
            }
            
            max = Math.Max(nums[i], max * nums[i]);
            min = Math.Min(nums[i], min * nums[i]);

            res = Math.Max(res, max);
        }

        return res;
    }
}