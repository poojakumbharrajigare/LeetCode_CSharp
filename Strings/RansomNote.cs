/*

Given two strings ransomNote and magazine, 
return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

*/

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length) return false;

        Dictionary<char, int> magazineCharCount = new Dictionary<char, int>();

        // Count characters in magazine
        foreach (char c in magazine)
        {
            if (magazineCharCount.ContainsKey(c))
            {
                magazineCharCount[c]++;
            }
            else
            {
                magazineCharCount[c] = 1;
            }
        }

        // Check if ransomNote can be constructed
        foreach (char c in ransomNote)
        {
            if (magazineCharCount.ContainsKey(c) && magazineCharCount[c] > 0)
            {
                magazineCharCount[c]--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}