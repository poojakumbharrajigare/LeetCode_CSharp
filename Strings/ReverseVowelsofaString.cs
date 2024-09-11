/*
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
*/

public class Solution {
    public string ReverseVowels(string s) {
        string vowels = "aeiouAEIOU";
        int left = 0;
        int right = s.Length - 1;
        var sArray = s.ToCharArray();

        while(left < right)
        {
            if(!vowels.Contains(sArray[left]))
            {
                left++;
            }

            if(!vowels.Contains(sArray[right]))
            {
                right--;
            }
            
            if(vowels.Contains(sArray[left]) && vowels.Contains(sArray[right]))
            {
                var temp = sArray[left];
                sArray[left] = sArray[right];
                sArray[right] = temp;
                left++;
                right--;
            }
        }

        return new string(sArray);
    }
}