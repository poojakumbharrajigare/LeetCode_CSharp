/*
Given an integer x, return true if x is a palindrome, and false otherwise.
*/

public class Solution {
    public bool IsPalindrome(int x) {
        string number = x.ToString();
        bool result = true;

        for(int index = 0; index < number.Length / 2; index++)
        {
            if(number[index] == number[number.Length - 1 - index])
                continue;
            else
                result = false;
        }

        return result;
    }
}