/*
Given an integer array nums, return true if there exists a triple of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k]. 
If no such indices exists, return false.
*/

public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first = Int32.MaxValue;
        int second = Int32.MaxValue;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] <= first)
                first = nums[i];
            else if(nums[i] <= second)
                second = nums[i];
            else
                return true;
        }
        
        return false;
    }
}