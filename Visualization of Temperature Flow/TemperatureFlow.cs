using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace Visualization_of_Temperature_Flow
{
    public class Wrap
    {
        [DllImport(@"D:\Visualization-of-Temperature-Flow-master\Release\TemperatureFlowC++.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int subtract(int N, int M);
        [DllImport(@"D:\Visualization-of-Temperature-Flow-master\Release\TemperatureFlowC++.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CalculateFlow_ParallelMode_Cplus(IntPtr grid, int N, int M, int n_threads);
        //[DllImport(@"C:\Users\islam\Documents\visual studio 2012\Projects\TemperatureFlowC++\Release\TemperatureFlowC++.dll", CallingConvention = CallingConvention.Cdecl)]
        //public static extern IntPtr return_new_cell(IntPtr tmp);
    }
    public enum Mode { Parallel, ParallelOmp, Serial };
    class TemperatureFlow
    {
        public static int num_threads;

        public static Cell[][] CalculateFlow(Cell[][] grid, Mode mode)
        {
            if (mode == Mode.Parallel) return CalculateFlow_ParallelMode(grid);
            else if(mode == Mode.ParallelOmp) return CalculateFlow_ParallelOmpMode(grid);
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

        public static Cell[][] CalculateFlow_ParallelOmpMode(Cell[][] grid)
        {
            int N = grid.Length, M = grid[0].Length;
            IntPtr result = Marshal.AllocHGlobal(Marshal.SizeOf(grid[0][0]) * N * M);
            IntPtr current = result;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Marshal.StructureToPtr(grid[i][j], current, true);
                    current = (IntPtr)((long)current + Marshal.SizeOf(grid[i][j]));
                }
            }
            IntPtr ptr = Wrap.CalculateFlow_ParallelMode_Cplus(result, N, M, num_threads);

            Cell[][] Finalgrid = new Cell[N][];
            IntPtr current2 = ptr;
            for (int i = 0; i < N; i++)
            {
                Finalgrid[i] = new Cell[M];
                for (int j = 0; j < M; j++)
                {
                    Finalgrid[i][j] = new Cell(new _Point(0, 0), CellType.NormalCell);
                    Marshal.PtrToStructure(current2, Finalgrid[i][j]);
                    //Marshal.FreeCoTaskMem( (IntPtr)Marshal.ReadInt32( current ));
                    Marshal.DestroyStructure(current2, typeof(Cell));
                    current2 = (IntPtr)((long)current2 + Marshal.SizeOf(Finalgrid[i][j]));
                }
            }
            Marshal.FreeHGlobal(result);
            Marshal.FreeHGlobal(ptr);
            return Finalgrid;
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
