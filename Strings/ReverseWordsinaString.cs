/*
Given an input string s, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

Return a string of the words in reverse order concatenated by a single space.

Note that s may contain leading or trailing spaces or multiple spaces between two words. 
The returned string should only have a single space separating the words. Do not include any extra spaces.
*/

public class Solution {
    public string ReverseWords(string s) {
        String[] str = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        String result = "";

        for (int i = str.Length - 1; i > 0; i--) 
        {
            result += str[i] + " ";
        }

        return result + str[0];
    }
}