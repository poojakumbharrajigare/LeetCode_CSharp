/*
You are given an integer array cost where cost[i] is the cost of ith step on a staircase. 
Once you pay the cost, you can either climb one or two steps.

You can either start from the step with index 0, or the step with index 1.

Return the minimum cost to reach the top of the floor.
*/

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        
        // Initialize variables to store the minimum cost for the last two steps
        int first = cost[0];  // Cost to reach step 0
        int second = cost[1];  // Cost to reach step 1
        
        // Iterate from step 2 to the last step
        for (int i = 2; i < n; i++) 
        {
            int curr = cost[i] + Math.Min(first, second);
            first = second;
            second = curr;
        }
        
        // The answer is the minimum cost to reach either of the last two steps
        return Math.Min(first, second);
    }
}