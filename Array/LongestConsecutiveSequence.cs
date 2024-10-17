/*
Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

You must write an algorithm that runs in O(n) time.
*/

public class Solution {
    public int LongestConsecutive(int[] nums) {
    var map = new Dictionary<int, int>();
    if(nums.Length == 1)
        return 1;

	for(int i=0; i<nums.Length; i++)
	{
        if(!map.ContainsKey(nums[i]))
        {
             map.Add(nums[i] , 1);
        }
	}
	
	int max = 0;
	foreach(var item in map)
	{
		int current = item.Key;
		if(item.Value == -1)
		{
			continue;
		}
	
		int count = 1;
		int prevEle = current-1;
		int nextEle = current+1;
		
		while(map.ContainsKey(prevEle))
		{
			count++;
			map[prevEle] = -1;
			prevEle = prevEle-1;
		}

		while(map.ContainsKey(nextEle))
		{
			count++;
			map[nextEle] = -1;
			nextEle = nextEle+1;
		}
		
		max = Math.Max(max, count);
	}
	
	return max;
    }          
}