/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.

*/

public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> map = new Dictionary<char, char>(){
                {')', '('},
                {'}', '{'},
                {']', '['},
           };
        
        if(string.IsNullOrEmpty(s) || s.Length % 2 != 0)
        {
            return false;
        }
        
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if(map.ContainsKey(c))
            {
                char top = stack.Count == 0 ? ' ' : stack.Pop();
                if(top != map[c])
                {
                    return false;
                } 
            } 
            else 
            {
                stack.Push(c);
            }
        }
    
        return stack.Count == 0;
    
    }

}