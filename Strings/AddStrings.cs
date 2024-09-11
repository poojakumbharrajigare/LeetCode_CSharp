/*
Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.

You must solve the problem without using any built-in library for handling large integers (such as BigInteger). 
You must also not convert the inputs to integers directly.
*/

public class Solution {
    public string AddStrings(string num1, string num2) {
        int num1Index = num1.Length - 1;
        int num2Index = num2.Length - 1;
        int carry = 0;
        StringBuilder sb = new();

        while (num1Index > -1 || num2Index > -1 || carry != 0) 
        {
            int a = num1Index > -1 ? num1[num1Index] - '0' : 0;
            int b = num2Index > -1 ? num2[num2Index] - '0' : 0;
            num1Index--;
            num2Index--;

            int sum = a + b + carry;
            sb.Insert(0, sum % 10);
            carry = sum / 10;
        }

        return sb.ToString();
    }
}