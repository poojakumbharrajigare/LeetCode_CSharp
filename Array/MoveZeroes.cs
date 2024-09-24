/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.
*/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int right = nums.Length - 1;

        for(int i = 0; i < nums.Length; i++)
        {
            int nonZero = i+1;

            if(nums[i] == 0)
            {
                while(nonZero < nums.Length && nums[nonZero] == 0)
                {
                    nonZero++;
                }

                if(nonZero < nums.Length)
                    Swap(ref nums[i], ref nums[nonZero]);
            }
        }
    }

    private void Swap(ref int number1, ref int number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }
}