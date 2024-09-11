/*
You are given an array items, where each items[i] = [typei, colori, namei] describes the type, color, and name of the ith item. You are also given a rule represented by two strings, ruleKey and ruleValue.

The ith item is said to match the rule if one of the following is true:

ruleKey == "type" and ruleValue == typei.
ruleKey == "color" and ruleValue == colori.
ruleKey == "name" and ruleValue == namei.
Return the number of items that match the given rule.
*/

public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int count = 0;

        foreach(var item in items)
        {
            if(ruleKey == "type" && ruleValue == item[0] ||
               ruleKey == "color" && ruleValue == item[1] ||
               ruleKey == "name" && ruleValue == item[2])
               {
                    count++;
               }
        }

        return count;
    }
}