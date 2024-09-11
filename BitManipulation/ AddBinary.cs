/*
Given two binary strings a and b, return their sum as a binary string.
*/

public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder result = new();
        int carry = 0;
        int aIndex = a.Length - 1;
        int bIndex = b.Length - 1;

        while(aIndex > -1 || bIndex > -1 || carry > 0)
        {
            int number1 = aIndex > -1 ? a[aIndex--] - '0' : 0;
            int number2 = bIndex > -1 ? b[bIndex--] - '0' : 0;

            int sum = number1 + number2 + carry;
            result.Insert(0, (sum % 2).ToString());
            carry = sum / 2;
        }

        return result.ToString();
    }
}