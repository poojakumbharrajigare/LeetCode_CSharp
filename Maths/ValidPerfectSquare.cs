/*
Given a positive integer num, return true if num is a perfect square or false otherwise.

A perfect square is an integer that is the square of an integer. In other words, it is the product of some integer with itself.

You must not use any built-in library function, such as sqrt.
*/

public class Solution {
    public bool IsPerfectSquare(int num) {
        long left = 1;
        long right = num/2;

        if(num == 1)
            return true;

        while(left <= right)
        {
            long mid = (left + right) / 2;

            long square = mid * mid;
            if(square == num)
                return true;
            else if(square > num)
                right = mid  - 1;
            else
                left = mid + 1;
        }

        return false;
    }
}