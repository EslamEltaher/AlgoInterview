////04 https://leetcode.com/problems/valid-parentheses/

//using System.Collections.Generic;

//public class Solution
//{
    
//    public bool IsValid(string s)
//    {
//        Stack<char> stack = new Stack<char>();

//        for (int i = 0; i < s.Length; i++)
//        {
//            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
//                stack.Push(s[i]);

//            else if (s[i] == ')' && (stack.Count == 0 || stack.Pop() != '('))
//                return false;
//            else if (s[i] == '}' && (stack.Count == 0 || stack.Pop() != '{'))
//                return false;
//            else if (s[i] == ']' && (stack.Count == 0 || stack.Pop() != '['))
//                return false;
//        }

//        if (stack.Count == 0)
//            return true;

//        return false;
//    }
//}