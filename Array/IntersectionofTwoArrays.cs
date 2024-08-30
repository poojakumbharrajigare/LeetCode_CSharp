/*
Given two integer arrays nums1 and nums2, return an array of their 
intersection
. Each element in the result must be unique and you may return the result in any order.
*/

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> result = new HashSet<int>();

        foreach(int item in nums2)
        {
            if(set1.Contains(item))
            {
                result.Add(item);
            }
        }

        return result.ToArray();
    }
}