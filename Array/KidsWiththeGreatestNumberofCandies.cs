/*
There are n kids with candies. You are given an integer array candies, 
where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, 
denoting the number of extra candies that you have.

Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, 
they will have the greatest number of candies among all the kids, or false otherwise.

Note that multiple kids can have the greatest number of candies.
*/

public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maxNumber = 0;
        IList<bool> result = new List<bool>();
        foreach(var number in candies)
        {
            if(number > maxNumber)
                maxNumber = number;
        }

        foreach(var number in candies)
        {
            result.Add(number + extraCandies >= maxNumber);
        }

        return result;
    }
}