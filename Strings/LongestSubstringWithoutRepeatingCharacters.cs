/*
Given a string s, find the length of the longest substring without repeating characters.
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null)
            return 0;

        int result = 0;
        string str = "";

        int i = 0;

        while(i < s.Length)
        {
            str += s[i];
            int j = i + 1;
            while(j < s.Length && !str.Contains(s[j]))
            {
                str += s[j];
                j++;
            }

            i++;
            result = Math.Max(result, str.Length);
            str = "";
        }

        return result;
    }
}