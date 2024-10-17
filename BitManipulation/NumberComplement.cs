/*
The complement of an integer is the integer you get when you flip all the 0's to 1's and all the 1's to 0's in its binary representation.

For example, The integer 5 is "101" in binary and its complement is "010" which is the integer 2.
Given an integer num, return its complement.
*/

public class Solution {
    public int FindComplement(int num) {
        // Initialize mask as 1
        int mask = 1;

        // Generate a mask with all bits set to 1 that covers the length of num's binary representation
        while (mask < num) {
            mask = (mask << 1) | 1;
        }

        // XOR num with the mask to get the complement
        return num ^ mask;
    }
}