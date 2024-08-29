/*

Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
typically using all the original letters exactly once.

*/

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
            
        Dictionary<char, int> mapping = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if(mapping.ContainsKey(c))
            {
                mapping[c]++;
            }
            else
            {
                mapping.Add(c,1);
            }
        }

        foreach(char c in t)
        {
            if(mapping.ContainsKey(c))
            {
                mapping[c]--;
            }
            else
            {
                return false;
            }

            if(mapping[c]==0)
            {
                mapping.Remove(c);
            }
        }

        return true;
    }
}