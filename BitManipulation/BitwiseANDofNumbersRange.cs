/*
Given two integers left and right that represent the range [left, right], return the bitwise AND of all numbers in this range, inclusive.
*/

public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        int shift = 0;

        while(left != right)
        {
            shift++;

            left = left>>1;
            right = right>>1;
        }

        return left << shift;
    }
}