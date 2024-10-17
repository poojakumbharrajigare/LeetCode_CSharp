/*
Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

A subarray is a contiguous non-empty sequence of elements within an array.
*/

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0;
        int sum = 0;
        Dictionary<int,int> map = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if(sum == k)
                count++;
                
            if(map.ContainsKey(sum-k))
                count += map[sum-k];
            
            if(map.ContainsKey(sum))
                map[sum] = map[sum] + 1;
            else
                map[sum] = 1;
        }

        return count;
    }
}