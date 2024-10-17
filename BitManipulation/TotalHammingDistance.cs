/*
The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

Given an integer array nums, return the sum of Hamming distances between all the pairs of the integers in nums.
*/

public class Solution {
    public int TotalHammingDistance(int[] nums) {
        int hammingDistance = 0;
        for(int i = 0; i < 32; i++) {
            int zeroBits = 0, oneBits = 0;
            for(int j = 0; j < nums.Length; j++) {
                int bit = (nums[j] >> i) & 1;
                if(bit == 1)
                    oneBits += 1;
                else
                    zeroBits += 1;
            }

            hammingDistance += zeroBits * oneBits;
        }

        return hammingDistance;
    }
}