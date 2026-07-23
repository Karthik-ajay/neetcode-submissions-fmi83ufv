public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new ();
        foreach (char c in s)
        {
            if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count > 0 && GetOpeningBrace (c) == stack.Peek())
                    stack.Pop();
                else
                    stack.Push(c);
            }
            else
                stack.Push(c);
        }
        return stack.Count == 0;
    }

    private char GetOpeningBrace (char c) => c switch {
        ')' => '(',
        ']' => '[',
        '}' => '{',
        _ => '\0'
    };
}
