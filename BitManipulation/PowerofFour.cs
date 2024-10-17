/*
Given an integer n, return true if it is a power of four. Otherwise, return false.

An integer n is a power of four, if there exists an integer x such that n == 4x.
*/

public class Solution {
    public bool IsPowerOfFour(int n) {
        return n > 0 && (n & (n - 1)) == 0 && (n & 0x55555555) != 0;
    }
}