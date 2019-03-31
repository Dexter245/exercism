using System;
using System.Collections.Generic;

public static class BracketPush
{
    public static bool IsPaired(string input)
    {
        Stack<int> stack = new Stack<int>();
        char[] cinput = input.ToCharArray();
        bool pairs = true;
        foreach(char c in cinput)
        {
            bool isOpen = false;
            bool isClose = false;
            int type = -1;
            if (c == '(' || c == '[' || c == '{')
                isOpen = true;
            else if (c == ')' || c == ']' || c == '}')
                isClose = true;
            if (c == '(' || c == ')')
                type = 1;
            if (c == '[' || c == ']')
                type = 2;
            if (c == '{' || c == '}')
                type = 3;
            if (type == -1)
                continue;
            if (isOpen)
            {
                stack.Push(type);
                continue;
            }
            else if (isClose)
            {
                int t;
                if (!stack.TryPop(out t) || !t.Equals(type))
                {
                    pairs = false;
                    break;
                }
            }

        }
        if (stack.Count > 0)
            pairs = false;
        return pairs;
    }
}
