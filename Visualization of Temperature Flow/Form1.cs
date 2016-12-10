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
            //  Glu.gluPerspective(45.0f, (double)width / (double)height, 0.01f, 5000.0f);
            Glu.gluOrtho2D(0,width,height,0);
            mesh = new Mesh(width, height, 50);
        }
        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(0, 0, 0, 0);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            mesh.Draw();
           
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

        private void simpleOpenGlControl1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
           // c1.position = new Point(x, y);
           //simpleOpenGlControl1.Refresh();
        }

        }
    }

