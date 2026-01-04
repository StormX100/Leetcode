/*
 * The board is made up of an m x n grid of cells, where each cell has an initial state: live(represented by a 1) or dead(represented by a 0). Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using the following four rules(taken from the above Wikipedia article):

    Any live cell with fewer than two live neighbors dies as if caused by under-population.
    Any live cell with two or three live neighbors lives on to the next generation.
    Any live cell with more than three live neighbors dies, as if by over-population.
    Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
*/

int[][] board = [[0, 1, 0], [0, 0, 1], [1, 1, 1], [0, 0, 0]]; // [[0,0,0],[1,0,1],[0,1,1],[0,1,0]]
GameOfLife solution = new GameOfLife();
solution.Play(board);


int width = board.GetLength(0);
int lenght = board[0].Length;
for (int i = 0; i < width; i++)
{
    for (int j = 0; j < lenght; j++)
    {
        Console.Write(board[i][j]);
    }

    Console.WriteLine();
}

public class GameOfLife
{
    public void Play(int[][] board)
    {
        int height = board.GetLength(0);
        int width = board[0].Length;
        int[,] clonedBoard = CloneBoard(board, height, width);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                var aliveNeighbours = CheckAliveNeighbours(clonedBoard, width, height, i, j);
                if (board[i][j] == 1)
                {
                    if (aliveNeighbours < 2) board[i][j] = 0;
                    if (aliveNeighbours == 2 || aliveNeighbours == 3) board[i][j] = 1;
                    if (aliveNeighbours > 3) board[i][j] = 0;
                }
                else
                {
                    if (aliveNeighbours == 3) board[i][j] = 1;
                }
            }
        }
    }

    private int CheckAliveNeighbours(int[,] board, int lenght, int width, int i, int j)
    {
        int aliveNeighbours = 0;
        if (i > 0) aliveNeighbours += board[i - 1,j];
        if (i < width - 1) aliveNeighbours += board[i + 1,j];
        if (j > 0) aliveNeighbours += board[i,j - 1];
        if (j < lenght - 1) aliveNeighbours += board[i,j + 1];
        if (i > 0 && j > 0) aliveNeighbours += board[i - 1,j - 1];
        if (i > 0 && j < lenght - 1) aliveNeighbours += board[i - 1,j + 1];
        if (i < width - 1 && j > 0) aliveNeighbours += board[i + 1,j - 1];
        if (i < width - 1 && j < lenght - 1) aliveNeighbours += board[i + 1,j + 1];

        return aliveNeighbours;
    }

    private int[,] CloneBoard(int[][] board, int width, int lenght)
    {
        int[,] clonedBoard = new int[width,lenght];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < lenght; j++)
            {
                clonedBoard[i,j] = board[i][j];
            }
        }

        return clonedBoard;
    }
}