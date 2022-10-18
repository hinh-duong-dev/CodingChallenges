using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }

                if (stack.Count == 0)
                {
                    return false;
                }

                switch (c)
                {
                    case '}':
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                        else {
                            return false;
                        }
                        break;
                    case ']':
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case ')':
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}