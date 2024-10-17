/*
Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

If target is not found in the array, return [-1, -1].

You must write an algorithm with O(log n) runtime complexity.
*/

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;
        int left = 0;
        int right = n -1;

        int[] ans = new int[2]{-1, -1};
        if(n==0 || (n == 1 && nums[0] != target))
            return ans;
        
        if(n == 1 && nums[0] == target)
        {
            ans[0] = ans[1] = 0; 
        }

        while(left <= right)
        {
            int mid = (left + right)/2;

            if(nums[mid] == target)
            {
                ans[0] = mid;
                right = mid - 1;
            }
            else if(nums[mid] < target)
            {
                left = mid + 1;
            }
            else
                right = mid - 1;

        }

        left = 0;
        right = n -1;
        while(left <= right)
        {
            int mid = (left + right)/2;

            if(nums[mid] == target)
            {
                ans[1] = mid;
                left = mid + 1;
            }
            else if(nums[mid] < target)
            {
                left = mid + 1;
            }
            else
                right = mid - 1;

        }

        return ans;
    }
}