public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // checking rows
        for (int i = 0; i < 9; i++)
        {
            HashSet<char> seen = new HashSet<char>();
            for (int j = 0; j < 9; j++)
            {
                if (seen.Contains(board[i][j]))
                    return false;
                else if (board[i][j] == '.')
                    continue;
                seen.Add(board[i][j]);
            }
        }

        // checking columns
        for (int i = 0; i < 9; i++)
        {
            HashSet<char> seen = new HashSet<char>();
            for (int j = 0; j < 9; j++)
            {
                if (seen.Contains(board[j][i]))
                    return false;
                else if (board[j][i] == '.')
                    continue;
                seen.Add(board[j][i]);
            }
        }

        // checking boxes
        for (int i = 0; i < 9; i++)
        {
            HashSet<char> seen = new HashSet<char>();
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    int row = (i / 3) * 3 + j;
                    int column = (i % 3) * 3 + k;
                    if (seen.Contains(board[row][column]))
                        return false;
                    else if (board[row][column] == '.')
                        continue;
                    seen.Add(board[row][column]);
                }
            }
        }
        return true;
    }
}
