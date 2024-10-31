using System;
using System.Collections.Generic;

public class Solution
{
    public bool solution(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s)
        {
            // 여는 괄호면 스택에 푸시
            if (c == '(')
            {
                stack.Push(c);
            }
            // 닫는 괄호면 스택에서 여는 괄호 팝
            else
            {
                // 스택에 남은 괄호가 없으면 false
                if(stack.Count == 0)
                {
                    return false;
                }
                // 남은 괄호가 있으면 팝
                else
                {
                    stack.Pop();
                }
            }
        }

        //다 끝나고 스택에 남은 괄호가 있으면 false
        if (stack.Count > 0)
            return false;

        return true;
    }
}