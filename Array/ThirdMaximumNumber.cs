/*
Given an integer array nums, return the third distinct maximum number in this array. 
If the third maximum does not exist, return the maximum number.
*/

public class Solution {
    public int ThirdMax(int[] nums) {
        int? firstMax = null, secondMax = null, thirdMax = null;

        foreach(int item in nums)
        {
            if (firstMax.HasValue && firstMax.Value == item || 
                secondMax.HasValue && secondMax.Value == item || 
                thirdMax.HasValue && thirdMax.Value == item) 
                {
                    continue; 
                }

            if(firstMax == null || firstMax < item)
            {
                thirdMax = secondMax;
                secondMax= firstMax;
                firstMax = item;
            }
            else if(secondMax == null || secondMax < item)
            {
                thirdMax = secondMax;
                secondMax = item;
            }
            else if(thirdMax == null || thirdMax < item)
                thirdMax = item;
        }

        return thirdMax.HasValue ? thirdMax.Value : firstMax.Value;
    }
}