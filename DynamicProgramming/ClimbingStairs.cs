/*
You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
*/

public class Solution {
    public int ClimbStairs(int n) {
        if(n == 0)
            return 0;

        int first = 1;
        int second = 2;

        if(n == 1)
            return first;
        if(n == 2)
            return second;

        int i = 3;
        int result = 0;
        while(i <= n)
        {
            result = first + second;
            first = second;
            second = result;
            i++;
        }

        return  result;
    }
}