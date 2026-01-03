/*Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

    Each row must contain the digits 1-9 without repetition.
    Each column must contain the digits 1-9 without repetition.
    Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
*/

using _36._Valid_Sudoku;

string[][] validBoard =
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]];

Solution solution = new Solution();
Console.WriteLine(solution.IsValidSudoku(validBoard)); // true

string[][] boardWithDuplicateNumbersInRows =
[["5","5",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]];

Console.WriteLine(solution.IsValidSudoku(boardWithDuplicateNumbersInRows)); // false

string[][] boardWithDuplicateNumbersInColumns =
[["5","3",".",".","7",".",".",".","."]
,["5",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]];

Console.WriteLine(solution.IsValidSudoku(boardWithDuplicateNumbersInColumns)); // false

string[][] boardWithDuplicateNumbersInBoxes =
[[".", ".", ".", ".", "5", ".", ".", "1", "."],
[".", "4", ".", "3", ".", ".", ".", ".", "."],
[".", ".", ".", ".", ".", "3", ".", ".", "1"],
["8", ".", ".", ".", ".", ".", ".", "2", "."],
[".", ".", "2", ".", "7", ".", ".", ".", "."],
[".", "1", "5", ".", ".", ".", ".", ".", "."],
[".", ".", ".", ".", ".", "2", ".", ".", "."],
[".", "2", ".", "9", ".", ".", ".", ".", "."],
[".", ".", "4", ".", ".", ".", ".", ".", "."]];

Console.WriteLine(solution.IsValidSudoku(boardWithDuplicateNumbersInBoxes)); // false