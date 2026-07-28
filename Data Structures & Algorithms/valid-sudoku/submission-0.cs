public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int row = 0; row < 9; row++)
        {
            HashSet<char> seen = new HashSet<char>();
            for (int i = 0; i < 9; i++)
            {
                if(board[row][i] == '.') continue;
                if(seen.Contains(board[row][i])) return false;
                seen.Add(board[row][i]);
            }
        }

        for(int column = 0; column < 9; column++)
        {
            HashSet<char> seen = new HashSet<char>();
            for (int i = 0; i < 9; i++)
            {
                if(board[i][column] == '.') continue;
                if(seen.Contains(board[i][column])) return false;
                seen.Add(board[i][column]);
            }
        }

        for (int rowStart = 0; rowStart < 9; rowStart += 3) {
            for (int colStart = 0; colStart < 9; colStart += 3) {
                HashSet<char> seen = new HashSet<char>();
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        char cell = board[rowStart + i][colStart + j];
                        if (cell == '.') continue;
                        if (seen.Contains(cell)) return false;
                        seen.Add(cell);
                    }
                }
            }
        }

        return true;
    }
}
