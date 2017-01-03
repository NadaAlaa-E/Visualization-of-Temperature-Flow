using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Color_Mapping;
namespace Visualization_of_Temperature_Flow
{
    public class Mesh
    {
        public Cell[][] grid;
        public int cellsize;
        public CellType targetType;
        public int rows, cols;

        public Mesh(int width, int height, int cellsize)
        {
            this.cellsize = cellsize;
            rows = (height / cellsize);
            cols = (width / cellsize);

            grid = new Cell[rows][];
            for (int i = 0; i < rows; i++)
            {
                grid[i] = new Cell[cols];
                for (int j = 0; j < cols; j++)
                {
                    grid[i][j] = new Cell(new _Point(j * cellsize, i * cellsize), CellType.NormalCell);
                }
            }
        }

        public void Update(Mode mode)
        {
            grid = TemperatureFlow.CalculateFlow(grid, mode);
        }

        public void Draw()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i][j].Draw(cellsize);
                }
            }
        }

        public void ChangeCell(int row, int col)
        {
            switch (targetType)
            {
                case CellType.Block:
                    grid[row][col] = new Cell(new _Point(col * cellsize, row * cellsize), CellType.Block);
                    break;

                case CellType.ColdSource:
                    grid[row][col] = new Cell(new _Point(col * cellsize, row * cellsize), CellType.ColdSource);
                    break;

                case CellType.HeatSource:
                    grid[row][col] = new Cell(new _Point(col * cellsize, row * cellsize), CellType.HeatSource);
                    break;

                case CellType.NormalCell:
                    grid[row][col] = new Cell(new _Point(col * cellsize, row * cellsize), CellType.NormalCell);
                    break;

                case CellType.Window:
                    grid[row][col] = new Cell(new _Point(col * cellsize, row * cellsize), CellType.Window);
                    break;
            }
        }
        public void UpdateCurrentMesh()
        {
            Parallel.For(0, rows, i =>
            {
                for (int j = 0; j < cols; j++)
                {
                    float ratio = (grid[i][j].temperature - Color_Mapper.minValue) / (Color_Mapper.maxValue - Color_Mapper.minValue);
                    grid[i][j].temperature = TmpData.min + ratio * (TmpData.max - TmpData.min);
                }
            });
            Color_Mapper.maxValue = TmpData.max;
            Color_Mapper.minValue = TmpData.min;
        }
    }
}