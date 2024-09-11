/*
You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
The digits are ordered from most significant to least significant in left-to-right order. 
The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

*/

public class Solution {
    public int[] PlusOne(int[] digits) {
         int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            //digits = 999999: result = it means all other digits will be zero.
            int[] result = new int[n + 1];
            result[0] = 1;

            return result;
    }
}