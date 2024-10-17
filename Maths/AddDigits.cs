/*
Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
*/

public class Solution {
    public int AddDigits(int num) {
        int sum = 0;

        if(num < 10)
            return num;

        while(num > 0)
        {
            int digit = num % 10;
            sum += digit;
            num = num/10;
        }

        return sum > 9 ? AddDigits(sum) : sum;
    }
}