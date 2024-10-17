/*
Given two integers a and b, return the sum of the two integers without using the operators + and -.
*/

public class Solution {
    public int GetSum(int a, int b) {
        return b == 0 ? a : GetSum(a ^ b, (a & b) << 1);
    }
}