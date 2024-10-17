/*
A peak element is an element that is strictly greater than its neighbors.

Given a 0-indexed integer array nums, find a peak element, and return its index. If the array contains multiple peaks, return the index to any of the peaks.

You may imagine that nums[-1] = nums[n] = -∞. In other words, an element is always considered to be strictly greater than a neighbor that is outside the array.

You must write an algorithm that runs in O(log n) time.
*/

public class Solution {
    public int FindPeakElement(int[] nums) {
        int n = nums.Length;
        int left = 1;
        int right = n - 2;

        if(n == 0)
            return -1;
            
        if(nums.Length == 1)
            return 0;

        if(nums[0] > nums[1])
            return 0;

        if(nums[n-1] > nums[n-2])
            return n-1;

        while(left <= right)
        {
            int mid = (left + right) / 2;

            if(nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                return mid;
            else if(nums[mid] > nums[mid - 1])
                left = mid + 1;
            else 
                right = mid - 1;
        }

        return -1;
    }
}