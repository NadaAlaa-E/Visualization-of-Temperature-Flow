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
        public Form1()
        {
            InitializeComponent();
            int height = simpleOpenGlControl1.Height;
            int width = simpleOpenGlControl1.Width;
            simpleOpenGlControl1.InitializeContexts();
            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            //  Glu.gluPerspective(45.0f, (double)width / (double)height, 0.01f, 5000.0f);
            Glu.gluOrtho2D(0, 200, 0, 200);
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
                        new SolidBrush(Color_Mapper.colors[i]), 
                        (i * colorsPanel.Width) / (colorArrayLength), 
                        0.0f, 
                        colorsPanel.Width / (colorArrayLength), 
                        colorsPanel.Height);
                }
                return;
            }
            for (int i = 0; i < colorArrayLength - 1; i++)
            {
                LinearGradientBrush b = new LinearGradientBrush(
                    new Rectangle(0, 0, colorsPanel.Width / (colorArrayLength - 1), colorsPanel.Height),
                    Color_Mapper.colors[i], 
                    Color_Mapper.colors[i + 1],
                    LinearGradientMode.Horizontal
                    );

                g.FillRectangle(
                    b,
                    (i * colorsPanel.Width) / (colorArrayLength - 1) + 1,
                    0.0f, 
                    colorsPanel.Width / (colorArrayLength - 1), 
                    colorsPanel.Height);
            }
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(0, 0);
            Gl.glVertex2f(0, 20);
            Gl.glVertex2f(20, 20);
            Gl.glVertex2f(20, 0);
            Gl.glEnd();
        }

        }
    }

