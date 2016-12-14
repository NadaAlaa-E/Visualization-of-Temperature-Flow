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
        public static void CalculateFlow(ref Cell[][] grid, Mode mode)
        {
            if (mode == Mode.Parallel) CalculateFlow_ParallelMode(grid);
            else if (mode == Mode.Serial) CalculateFlow_SerialMode(grid);
        }

        public static void CalculateFlow_SerialMode(Cell[][] grid)
        {
            int[] dirX = { 0, 0, 1, 1, 1, -1, -1, -1 };
            int[] dirY = { 1, -1, 0, 1, -1, 0, 1, -1 };
            int N = grid.Length, M = grid[0].Length;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    UpdateCell(ref grid, i, j, N, M);
                }
            }
        }

        public static void CalculateFlow_ParallelMode(Cell[][] grid)
        {
            int N = grid.Length, M = grid[0].Length;

            Parallel.For(0, N, i =>
            {
                for (int j = 0; j < M; j++)
                {
                    UpdateCell(ref grid, i, j, N, M);
                }
            });
        }

        private static void UpdateCell(ref Cell[][] grid, int i, int j, int N, int M)
        {
            int[] dirX = { 0, 0, 1, 1, 1, -1, -1, -1 };
            int[] dirY = { 1, -1, 0, 1, -1, 0, 1, -1 };
            if (grid[i][j].type == CellType.NormalCell)
            {
                float newVal = grid[i][j].temperature;
                int num_Neighbours = 1;
                for (int k = 0; k < dirX.Length; k++)
                {
                    if (IsValid(i + dirX[k], j + dirY[k], N, M))
                    {
                        Cell neighbour = grid[i + dirX[k]][j + dirY[k]];
                        if (neighbour.type != CellType.Block)
                        {
                            newVal += neighbour.temperature;
                            num_Neighbours++;
                        }
                    }
                }
                grid[i][j].temperature = newVal / num_Neighbours;
            }
        }

        private static bool IsValid(int x, int y, int N, int M)
        {
            return x >= 0 && x < N && y >= 0 && y < M;
        }
    }
}
