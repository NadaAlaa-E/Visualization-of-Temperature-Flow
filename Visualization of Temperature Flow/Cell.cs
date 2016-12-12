using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Tao.OpenGl;
using Color_Mapping;

namespace Visualization_of_Temperature_Flow
{
    public enum CellType { Block, HeatSource, ColdSource, NormalCell, Window };
    public class Cell
    {
        public float temperature; //scalar value 
        public Point position;
        public CellType type;
        NormColor color;

        public Cell(Point position, CellType type)
        {
            this.position = position;
            this.type = type;

            if (type == CellType.ColdSource) temperature = Color_Mapper.minValue;
            else if (type == CellType.HeatSource) temperature = Color_Mapper.maxValue;
            else if(type != CellType.Block) temperature = (Color_Mapper.minValue+Color_Mapper.maxValue) / 2;
        }
        public void Draw(int uintSize)
        {
            if (type == CellType.Block) color = NormColor.NormalizeColor(Color.Black);
            else if (type == CellType.Window) color = NormColor.NormalizeColor(Color.Yellow);
            else color = NormColor.NormalizeColor(Color_Mapper.ValueToColor(temperature));
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
