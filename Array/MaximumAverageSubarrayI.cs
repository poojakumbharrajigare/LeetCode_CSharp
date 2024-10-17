/*
You are given an integer array nums consisting of n elements, and an integer k.
Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.
*/

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int start = 0;
        int end = k;
        double maxAverage = 0;
        double sum = 0;

        for(int i =0; i< k; i++)
        {
            sum += nums[i];
        }

        maxAverage = sum / k;

        while(end < nums.Length)
        {
            sum -= nums[start];
            sum += nums[end];
            double average = sum / k;
            maxAverage = Math.Max(maxAverage, average); 
            start++;
            end++;
        }

        return maxAverage;
    }
}