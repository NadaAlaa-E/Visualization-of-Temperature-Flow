using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Visualization_of_Temperature_Flow
{
   public class Mesh
    {
       Cell[,] grid;
       int cellsize , rows , cols;
       public Mesh(int width,int height,int cellsize)
       {
           this.cellsize = cellsize;
           rows = (height/cellsize)+1;
           cols = (width/cellsize)+1;
           grid = new Cell[rows,cols];
           for (int i = 0; i < rows; i++)
               for (int j = 0; j < cols; j++)
                   grid[i, j] = new Cell(new Point(j * cellsize, i * cellsize));
       }
       public void Update()
       { 
       
       }
       public void Draw()
       {
           for (int i = 0; i < rows; i++)
               for (int j = 0; j < cols; j++)
                   grid[i, j].Draw(cellsize);
       }
    }
}
