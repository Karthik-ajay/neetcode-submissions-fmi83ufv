public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> dict = new (){
            {')', '('},
            {']', '['},
            {'}', '{'}
        };
        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (dict.ContainsValue(c))
                stack.Push(c);
            else
            {
                if (stack.Count > 0 && stack.Peek() == dict[c])
                    stack.Pop();
                else 
                    stack.Push(c);
            }

        }

        return stack.Count == 0;
    }
}
