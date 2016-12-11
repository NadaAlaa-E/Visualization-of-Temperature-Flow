using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Tao.OpenGl;
namespace Visualization_of_Temperature_Flow
{
    public partial class Form1 : Form
    {
        int height, width;
        Mesh mesh;
        public Form1()
        {
            InitializeComponent();
            height = simpleOpenGlControl1.Height;
            width = simpleOpenGlControl1.Width;
            simpleOpenGlControl1.InitializeContexts();
            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
<<<<<<< HEAD
            //  Glu.gluPerspective(45.0f, (double)width / (double)height, 0.01f, 5000.0f);
            Glu.gluOrtho2D(0,width,height,0);
         ////
=======
            Glu.gluOrtho2D(0, width, height, 0);

>>>>>>> Initial logic in serial mode
            mesh = new Mesh(width, height, 20);
            mesh.targetType = CellType.NormalCell;
            normalCellRadioBtn.Checked = true;
        }
        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(0, 0, 0, 0);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            mesh.Draw();
<<<<<<< HEAD
           
=======
>>>>>>> Initial logic in serial mode
        }

        private void colorsPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = colorsPanel.CreateGraphics();
            int colorArrayLength = Color_Mapper.colors.Length;
            //////////////////////////////////////////      

            if (false)// meshManager.mappingMode == Mapping_Mode.Discrete)
            {
                for (int i = 0; i < colorArrayLength; i++)
                {
                    g.FillRectangle(
<<<<<<< HEAD
                        new SolidBrush(Color_Mapper.colors[i]), 
                        (i * colorsPanel.Width) / (colorArrayLength), 
                        0.0f, 
                        colorsPanel.Width / (colorArrayLength), 
=======
                        new SolidBrush(Color_Mapper.colors[i]),
                        (i * colorsPanel.Width) / (colorArrayLength),
                        0.0f,
                        colorsPanel.Width / (colorArrayLength),
>>>>>>> Initial logic in serial mode
                        colorsPanel.Height);
                }
                return;
            }
            for (int i = 0; i < colorArrayLength - 1; i++)
            {
                LinearGradientBrush b = new LinearGradientBrush(
                    new Rectangle(0, 0, colorsPanel.Width / (colorArrayLength - 1), colorsPanel.Height),
<<<<<<< HEAD
                    Color_Mapper.colors[i], 
=======
                    Color_Mapper.colors[i],
>>>>>>> Initial logic in serial mode
                    Color_Mapper.colors[i + 1],
                    LinearGradientMode.Horizontal
                    );

                g.FillRectangle(
                    b,
                    (i * colorsPanel.Width) / (colorArrayLength - 1) + 1,
<<<<<<< HEAD
                    0.0f, 
                    colorsPanel.Width / (colorArrayLength - 1), 
=======
                    0.0f,
                    colorsPanel.Width / (colorArrayLength - 1),
>>>>>>> Initial logic in serial mode
                    colorsPanel.Height);
            }
        }

        private void simpleOpenGlControl1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
            int row = y / mesh.cellsize, col = x / mesh.cellsize;
            mesh.ChangeCell(row, col);
            simpleOpenGlControl1.Refresh();
        }

        private void blockRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (blockRadioBtn.Checked)
                mesh.targetType = CellType.Block;
        }

        private void heatSourceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (heatSourceRadioBtn.Checked)
<<<<<<< HEAD
            mesh.targetType = CellType.HeatSource;
=======
                mesh.targetType = CellType.HeatSource;
>>>>>>> Initial logic in serial mode
        }

        private void coldSourceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (coldSourceRadioBtn.Checked)
                mesh.targetType = CellType.ColdSource;
        }

        private void normalCellRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (normalCellRadioBtn.Checked)
                mesh.targetType = CellType.NormalCell;
<<<<<<< HEAD
        }

        private void windowRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (windowRadioBtn.Checked)
                mesh.targetType = CellType.Window;
        }

=======
>>>>>>> Initial logic in serial mode
        }

        private void windowRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (windowRadioBtn.Checked)
                mesh.targetType = CellType.Window;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

        }

    }
<<<<<<< HEAD

=======
}
>>>>>>> Initial logic in serial mode
