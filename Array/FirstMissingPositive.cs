/*
Given an unsorted integer array nums. Return the smallest positive integer that is not present in nums.

You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.
*/

public class Solution {
    public int FirstMissingPositive(int[] nums) {
      int n = nums.Length;
        
        // Step 1: Place each number in its correct position (i.e., nums[i] should be i+1)
        for (int i = 0; i < n; i++) 
        {
            // Keep swapping while nums[i] is a positive number <= n and it is not in its correct place
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) 
            {
                Swap(ref nums[i], ref nums[nums[i] - 1]);
            }
        }

        for (int i = 0; i < n; i++) 
        {
            if (nums[i] != i + 1) 
            {
                return i + 1; 
            }
        }

        return n + 1;
    }

    private void Swap(ref int number1, ref int number2) {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }
}