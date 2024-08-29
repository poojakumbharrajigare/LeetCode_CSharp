/*
Given two integer arrays nums1 and nums2, return an array of their intersection. 
Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
*/

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> result = new List<int>();

        foreach( int item in nums1)
        {
            if(map.ContainsKey(item))
            {
                map[item]++;
            }
            else
            {
                map.Add(item, 1);
            }
        }

        foreach(int item in nums2)
        {
            if(map.ContainsKey(item))
            {
                result.Add(item);
                map[item]--;
                if(map[item] == 0)
                {
                    map.Remove(item);
                }
            }
        }

        return result.ToArray();
    }
}