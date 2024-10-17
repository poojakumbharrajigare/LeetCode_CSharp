/*
Given an integer array nums and an integer k, return true if nums has a good subarray or false otherwise.

A good subarray is a subarray where: its length is at least two, and the sum of the elements of the subarray is a multiple of k.

Note that:A subarray is a contiguous part of the array.
An integer x is a multiple of k if there exists an integer n such that x = n * k. 0 is always a multiple of k.
*/

public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        int remainder = 0;
        Dictionary<int, int> remainders = new Dictionary<int, int>();
        remainders[0] = -1;
        
        for(int i =0; i < nums.Length; i++)
        {
            remainder = (remainder + nums[i]) % k;

            if(remainders.ContainsKey(remainder))
            {
                if(i - remainders[remainder] > 1)
                    return true;
            }
            else
            {
                remainders.Add(remainder, i);
            }
        }

        return false;
    }
}