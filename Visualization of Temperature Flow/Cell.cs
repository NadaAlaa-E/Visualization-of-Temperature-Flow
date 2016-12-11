using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Tao.OpenGl;
namespace Visualization_of_Temperature_Flow
{
<<<<<<< HEAD
    public enum CellType { Block, HeatSource, ColdSource, NormalCell, Window}; 
    public class Cell
    {
        double temperature; //scalar value 
        NormColor color;
        public Point position;
        public CellType type;
        public Cell(Point position,Color color,CellType type)
=======
    public enum CellType { Block, HeatSource, ColdSource, NormalCell, Window };
    public class Cell
    {
        public double temperature; //scalar value 
        NormColor color;
        public Point position;
        public CellType type;
        public Cell(Point position, Color color, CellType type)
>>>>>>> Initial logic in serial mode
        {
            this.position = position;
            this.color = NormColor.NormalizeColor(color);
            this.type = type;
        }
<<<<<<< HEAD
        public void Draw (int uintSize)
        {
           // color = Color_Mapper.ValueToColor(temperature, edge);
=======
        public void Draw(int uintSize)
        {
            // color = Color_Mapper.ValueToColor(temperature, edge);
>>>>>>> Initial logic in serial mode
            Gl.glColor3d(color.R, color.G, color.B);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(position.X, position.Y);
            Gl.glVertex2f(position.X, position.Y + uintSize);
            Gl.glVertex2f(position.X + uintSize, position.Y + uintSize);
            Gl.glVertex2f(position.X + uintSize, position.Y);
            Gl.glEnd();
        }

    }
}
