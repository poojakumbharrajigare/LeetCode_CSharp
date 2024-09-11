/*
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.
*/

public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> set = new();
        int newNumber = 0;
        
        while(n != 1)
        {
            newNumber = 0;
            
            while(n > 0)
            {
                int digit = n % 10;
                n = n / 10;
                newNumber += digit * digit;
            }

            if(set.Contains(newNumber))
                return false;

            set.Add(newNumber);
            n = newNumber;
        }

        return true;
    }
}