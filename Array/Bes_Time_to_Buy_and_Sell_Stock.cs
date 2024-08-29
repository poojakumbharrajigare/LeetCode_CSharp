/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

*/

public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int maxDiff = 0;
        for(int i = 1; i < prices.Length; i++)
        {
            if(min < prices[i])
            {
                int diff = prices[i] - min;
                if(maxDiff < diff)
                {
                    maxDiff = diff;
                }
            } 
            else
            {
                min = prices[i];
            }
        }

        return maxDiff;
    }
}
