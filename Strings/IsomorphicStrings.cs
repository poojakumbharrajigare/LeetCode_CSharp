/*
Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. 
No two characters may map to the same character, but a character may map to itself.

*/

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, char> mapSToT = new Dictionary<char, char>();
        Dictionary<char, char> mapTToS = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char charS = s[i];
            char charT = t[i];

            if (mapSToT.ContainsKey(charS))
            {
                if (mapSToT[charS] != charT)
                {
                    return false;
                }
            }
            else
            {
                mapSToT.Add(charS,charT);
            }

            if (mapTToS.ContainsKey(charT))
            {
                if (mapTToS[charT] != charS)
                {
                    return false;
                }
            }
            else
            {
                mapTToS.Add(charT, charS);
            }
        }

        return true;
    }
}