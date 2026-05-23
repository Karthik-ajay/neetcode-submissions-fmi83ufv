public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case ')':
                    if (stack.Count > 0 && stack.Peek() == '(')
                        stack.Pop();
                    else
                        stack.Push(s[i]);
                    break;
                case ']':
                    if (stack.Count > 0 && stack.Peek() == '[')
                        stack.Pop();
                    else
                        stack.Push(s[i]);
                    break;
                case '}':
                    if (stack.Count > 0 && stack.Peek() == '{')
                        stack.Pop();
                    else
                        stack.Push(s[i]);
                    break;
                default: 
                    stack.Push(s[i]);
                    break;
            }       
        }
        return stack.Count == 0;
    }
}
