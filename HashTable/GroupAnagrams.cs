/*
Given an array of strings strs, group the  anagrams together. You can return the answer in any order.
*/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

        foreach(var str in strs)
        {
            var sortedStr = String.Concat(str.OrderBy(ch => ch));

            if(!dict.ContainsKey(sortedStr))
            {
                dict[sortedStr] = new List<string>();
            }

            dict[sortedStr].Add(str);
        }

        return dict.Values.ToList();
    }
}