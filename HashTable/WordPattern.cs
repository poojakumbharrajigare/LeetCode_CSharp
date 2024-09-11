/*
Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s. 
Specifically:

Each letter in pattern maps to exactly one unique word in s.
Each unique word in s maps to exactly one letter in pattern.
No two letters map to the same word, and no two words map to the same letter.
*/

public class Solution {
    public bool WordPattern(string pattern, string s) {
        var wordArray = s.Split(' ');
        var map = new Dictionary<char, string>();

        for (int i = 0; i < pattern.Length; i++)
        {
            if(wordArray.Count() != pattern.Length)
                return false;

            if (map.ContainsKey(pattern[i]))
            {
                if (wordArray[i] != map[pattern[i]])
                    return false;
            }
            else
            {
                if (map.ContainsValue(wordArray[i]))
                    return false;

                map.Add(pattern[i], wordArray[i]);
            }
        }

        return true;
    }
}