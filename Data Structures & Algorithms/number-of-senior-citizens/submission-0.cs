public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
        foreach (string detail in details)
        {
            int age = Int32.Parse(detail.Substring(11, 2));
            if (age > 60)
                count++;
        }
    return count;
    }
}