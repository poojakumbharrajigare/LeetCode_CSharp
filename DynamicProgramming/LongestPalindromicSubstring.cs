/*
Given a string s, return the longest palindromic substring in s.
*/

public class Solution {
    public string LongestPalindrome(string s) {
            int maxLength = 0;
            var maxLengthStr="";
            if(s.Length == 1)
                return s;
            for (int i = 0; i < s.Length; i++)
            {
                //Odd Palindrom
                int L = i; int R = i;
                while (L>=0 && R<s.Length && s[L]== s[R])
                {
                    if (R - L + 1 > maxLength)
					{
                        maxLength = R - L + 1;
                        maxLengthStr = s.Substring(L, R - L + 1);
                    }
                    L--;
                    R++;
                }

                //Even Palindrom
                L = i; R = i+1;
                while (L >= 0 && R < s.Length && s[L] == s[R])
                {
                    if (R - L + 1 > maxLength)
                    {
                        maxLength = R - L + 1;
                        maxLengthStr = s.Substring(L, R - L + 1);
                    }
                    L--;
                    R++;
                }

            }
            return maxLengthStr;
    }
}