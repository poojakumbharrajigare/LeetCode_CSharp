/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
*/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0)
            return "";
        
        if(strs.Length == 1)
            return strs[0];

        int min = strs[0].Length;
        for(int i = 1; i < strs.Length; i++)
        {
            if(min > strs[i].Length)
            {
                min = strs[i].Length;
            }
        }

        int prefixIndex = 0;
        string result = "";
        while(prefixIndex < min)
        {
            for(int i = 1; i < strs.Length; i++)
            {
                if(strs[0][prefixIndex] != strs[i][prefixIndex])
                {
                    return result;
                }
            }

            result += strs[0][prefixIndex];
            prefixIndex++;
        }

        return result;
    }
}