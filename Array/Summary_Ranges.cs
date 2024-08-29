/*
You are given a sorted unique integer array nums.

A range [a,b] is the set of all integers from a to b (inclusive).

Return the smallest sorted list of ranges that cover all the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.

Each range [a,b] in the list should be output as:

"a->b" if a != b
"a" if a == b
*/

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> result = new List<string>();
        int startIndex = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(i != nums.Length -1) 
            {
                if(nums[i+1] == nums[i]+1)
                {
                    continue;
                }
            }
           
            string range = "";
            if(startIndex == i)
                range = nums[startIndex].ToString();
            else
                range = nums[startIndex] + "->" + nums[i];

            result.Add(range);
            startIndex = i + 1;

        }

        return result;
    }
}