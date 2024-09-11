/*
For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t 
(i.e., t is concatenated with itself one or more times).

Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
*/

public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if(str1 + str2 != str2 + str1)
        {
            return "";
        }

        int gcdLen = GCD(str1.Length, str2.Length);
        
        return str1.Substring(0, gcdLen);
    }

    private int GCD(int n1, int n2)
    {
        while (n1 != 0 && n2 != 0)
        {
            if (n1 > n2)
            {
                n1 %= n2;
            } 
            else 
            {
                n2 %= n1;
            }
        }

        return n1 | n2; // return n1 == 0 ? n2 : n1;
    }
}