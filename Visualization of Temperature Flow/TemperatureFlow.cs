using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualization_of_Temperature_Flow
{
    public enum Mode { Parallel, Serial };
    class TemperatureFlow
    {
        public static Cell[][] CalculateFlow(Cell[][] grid, Mode mode)
        {
            if (mode == Mode.Parallel) return CalculateFlow_ParallelMode(grid);
            else return CalculateFlow_SerialMode(grid);
        }

        public static Cell[][] CalculateFlow_SerialMode(Cell[][] grid)
        {
            int[] dirX = { 0, 0, 1, 1, 1, -1, -1, -1 };
            int[] dirY = { 1, -1, 0, 1, -1, 0, 1, -1 };
            int N = grid.Length, M = grid[0].Length;
            Cell[][] newGrid = new Cell[N][];

            for (int i = 0; i < N; i++)
            {
                newGrid[i] = new Cell[M];
                for (int j = 0; j < M; j++)
                {
                    newGrid[i][j] = UpdateCell(grid, i, j, N, M);
                }
            }
            return newGrid;
        }

        public static Cell[][] CalculateFlow_ParallelMode(Cell[][] grid)
        {
            int N = grid.Length, M = grid[0].Length;
            Cell[][] newGrid = new Cell[N][];

            for (int i = 0; i < N; i++) newGrid[i] = new Cell[M];

            Parallel.For(0, N, i =>
            {
                Parallel.For(0, M, j =>
                {
                    newGrid[i][j] = UpdateCell(grid, i, j, N, M);
                });
            });
            return newGrid;
        }

        private static Cell UpdateCell(Cell[][] grid, int i, int j, int N, int M)
        {
            int[] dirX = { 0, 0, 1, 1, 1, -1, -1, -1 };
            int[] dirY = { 1, -1, 0, 1, -1, 0, 1, -1 };
            Cell newCell = new Cell(grid[i][j]);

            int num_Neighbours = 1;
            if (grid[i][j].type == CellType.NormalCell)
            {
                for (int k = 0; k < dirX.Length; k++)
                {
                    if (IsValid(i + dirX[k], j + dirY[k], N, M))
                    {
                        Cell neighbour = grid[i + dirX[k]][j + dirY[k]];
                        if (neighbour.type != CellType.Block)
                        {
                            newCell.temperature += neighbour.temperature;
                            num_Neighbours++;
                        }
                    }
                }
            }
            newCell.temperature /= num_Neighbours;
            return newCell;
        }

        private static bool IsValid(int x, int y, int N, int M)
        {
            return x >= 0 && x < N && y >= 0 && y < M;
        }
    }
}
