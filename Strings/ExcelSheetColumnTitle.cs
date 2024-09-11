/*
Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
*/

public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder result = new();
         while (columnNumber > 0)
        {
            result.Insert(0, (char)(((columnNumber - 1) % 26) + 'A'));

            columnNumber = (columnNumber - 1) / 26;
        }

        return result.ToString();
    }
}