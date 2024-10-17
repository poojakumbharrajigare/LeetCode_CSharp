/*
Given an array of strings words, return the words that can be typed using letters of the alphabet on only one row of American keyboard like the image below.

In the American keyboard:

the first row consists of the characters "qwertyuiop",
the second row consists of the characters "asdfghjkl", and
the third row consists of the characters "zxcvbnm".
*/

public class Solution {
    public string[] FindWords(string[] words) {
        var validWords = new List<string>();
		
		var row1 = "qwertyuiop";
		var row2 = "asdfghjkl";
		var row3 = "zxcvbnm";
		
		foreach (var word in words)
		{
            var temp = word.ToLower();
			if (temp.Count(c => !row1.Contains(c)) == 0 ||
			    temp.Count(c => !row2.Contains(c)) == 0 ||
				temp.Count(c => !row3.Contains(c)) == 0 )
			{
				validWords.Add(word);
			}
		}
		
		return validWords.ToArray();

    }
}