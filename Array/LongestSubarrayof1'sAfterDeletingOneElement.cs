/*
Given a binary array nums, you should delete one element from it.

Return the size of the longest non-empty subarray containing only 1's in the resulting array. Return 0 if there is no such subarray.
*/

public class Solution {
    public int LongestSubarray(int[] nums) {
        int countZero = 0;
        int maxLen = 0;
        int start = 0;

        for(int end = 0; end < nums.Length; end++)
        {
            if(nums[end] == 0)
                countZero++;

            while(countZero > 1 && start < end)
            {
                if(nums[start++] == 0)
                {
                    countZero--;
                }
            }

            maxLen = Math.Max(maxLen, end - start);
        }
        
        return maxLen;
    }
}