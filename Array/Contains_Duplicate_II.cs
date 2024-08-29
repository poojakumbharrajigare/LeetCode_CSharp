/*
Given an integer array nums and an integer k, 
return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
*/

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> mapping = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(mapping.ContainsKey(nums[i]))
            {
                if(Math.Abs(mapping[nums[i]] - i) <= k)
                    return true;
                
                mapping[nums[i]] = i;
            }
            else
            {
                mapping[nums[i]] = i;
            }
        }

        return false;
    }
}