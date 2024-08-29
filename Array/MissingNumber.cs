/*
Given an array nums containing n distinct numbers in the range [0, n], 
return the only number in the range that is missing from the array.
*/

public class Solution {
    public int MissingNumber(int[] nums) {
        /*
        Complexity
        Time complexity: O(n)
        Space complexity: O(1)
        */

        int n = nums.Length;
        // Calculate the expected sum of consecutive integers from 0 to n
        int expectedSum = n * (n + 1) / 2;
        
        int actualSum = 0;
        foreach (int num in nums) {
            actualSum += num;
        }
        
        return expectedSum - actualSum;

        /*
        Complexity
        Time complexity: O(n)
        Space complexity: O(n)
        */

        /*
        HashSet<int> set = new HashSet<int>(nums);

        for(int number = 0; number <= nums.Length; number++)
        {
            if(!set.Contains(number))
                return number;
        }

        return 0;
        */
    }
}