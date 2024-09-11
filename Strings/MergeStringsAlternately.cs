/*
You are given two strings word1 and word2. 
Merge the strings by adding letters in alternating order, starting with word1. 
If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.
*/

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder result = new();
        int word1Index = 0;
        int word2Index = 0;

        while(word1Index < word1.Length || word2Index < word2.Length)
        {
            string first = word1Index < word1.Length ? (word1[word1Index++]).ToString() : "";
            string second = word2Index < word2.Length ? (word2[word2Index++]).ToString() : "";
            result.Append(first);
            result.Append(second);
        }

        return result.ToString();
    }
}