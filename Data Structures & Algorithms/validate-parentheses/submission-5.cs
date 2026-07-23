public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new ();

        foreach (char c in s)
        {
            switch (c)
            {
                case ')':
                    if (!(stack.Count == 0) && stack.Peek() == '(')
                        stack.Pop();
                    else
                        stack.Push(c);
                    break;
                case ']':
                    if (!(stack.Count == 0) && stack.Peek() == '[')
                        stack.Pop();
                    else
                        stack.Push(c);
                    break;
                case '}':
                    if (!(stack.Count == 0) && stack.Peek() == '{')
                        stack.Pop();
                    else
                        stack.Push(c);
                    break;
                default : 
                    stack.Push(c);
                    break;
            }
        }
        return stack.Count == 0;
    }
}
