using System;
using System.Collections.Generic;
using System.Text;

namespace _36._Valid_Sudoku
{
    public class Solution
    {
        private const int SUDOKU_LENGHT = 9;
        private const int SUDOKU_BOX_LENGHT = 3;

        public bool IsValidSudoku(string[][] board)
        {
            for (int i = 0; i < SUDOKU_LENGHT; i++)
            { 
                HashSet<string> rowNumbers = new HashSet<string>();
                HashSet<string> columnNumbers = new HashSet<string>();

                for (int j = 0; j < SUDOKU_LENGHT; j++)
                {
                    if (CheckNumberDuplication(rowNumbers, board[i][j]) == false) return false;
                    if (CheckNumberDuplication(columnNumbers, board[j][i]) == false) return false;
                }
            }

            return CheckSudokuBoxes(board);
        }      

        private bool CheckNumberDuplication(HashSet<string> numbers, string number)
        {
            if (number != ".")
            {
                if (numbers.Contains(number)) return false;
                else numbers.Add(number);
            }

            return true;
        }

        private bool CheckSudokuBoxes(string[][] board)
        {
            for (int i = 1; i < SUDOKU_LENGHT; i += SUDOKU_BOX_LENGHT)
            {
                for (int j = 1; j < SUDOKU_LENGHT; j += SUDOKU_BOX_LENGHT)
                {
                    HashSet<string> boxNumbers = new HashSet<string>();
                    if (CheckNumberDuplication(boxNumbers, board[i - 1][j - 1]) == false) return false;
                    if (CheckNumberDuplication(boxNumbers, board[i - 1][j]) == false) return false;
                    if (CheckNumberDuplication(boxNumbers, board[i - 1][j + 1]) == false) return false;
                    if (CheckNumberDuplication(boxNumbers, board[i][j - 1]) == false) return false;
                    if (CheckNumberDuplication(boxNumbers, board[i][j]) == false) return false;
                    if (CheckNumberDuplication(boxNumbers, board[i][j + 1]) == false) return false;
                    if (CheckNumberDuplication(boxNumbers, board[i + 1][j - 1]) == false) return false;
                    if (CheckNumberDuplication(boxNumbers, board[i + 1][j]) == false) return false;
                    if (CheckNumberDuplication(boxNumbers, board[i + 1][j + 1]) == false) return false;
                }
            }

            return true;
        }
    }
}
