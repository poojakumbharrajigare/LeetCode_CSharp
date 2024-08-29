/*
Given an integer array nums, 
return true if any value appears at least twice in the array, and return false if every element is distinct.
*/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
       HashSet<int> set = new HashSet<int>(nums);
        
       return nums.Length != set.Count;
       
       /* Another solution with Dictionary 
       
       Dictionary<int,int> map = new Dictionary<int,int>();

        for(int index = 0; index < nums.Length; index++)
        {
            if(map.ContainsKey(nums[index]))
            {
                return true;
            }
            else
                map.Add(nums[index], 1);
        }

        return false;
        */
    }
}