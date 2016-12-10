using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Tao.OpenGl;
namespace Visualization_of_Temperature_Flow
{
    public enum CellType { Block, HeatSource, ColdSource, NormalCell, Window}; 
    public class Cell
    {
        double temperature;
        NormColor color;
        public Point position;
        public CellType type;
        public Cell(Point position)
        {
            this.position = position;
            color = NormColor.NormalizeColor(Color.Green);
        }
        public void Draw (int uintSize)
        {
           // color = Color_Mapper.ValueToColor(temperature, edge);
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
