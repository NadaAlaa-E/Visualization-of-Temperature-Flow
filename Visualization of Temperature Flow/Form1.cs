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
using Color_Mapping;
using System.Threading;
namespace Visualization_of_Temperature_Flow
{
    public partial class Form1 : Form
    {
        int height, width;
        BackgroundWorker _worker = null;
        Mesh mesh;
        Mode mode;

        public Form1()
        {
            InitializeComponent();
            height = simpleOpenGlControl1.Height;
            width = simpleOpenGlControl1.Width;
            simpleOpenGlControl1.InitializeContexts();
            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(0, width, height, 0);
            sideTxt.Text = "20";
            mode = Mode.Serial;
            mesh = new Mesh(width, height, 20);
            mesh.targetType = CellType.NormalCell;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(0, 0, 0, 0);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            mesh.Draw();
        }

        private void blockRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (blockRadioBtn.Checked)
                mesh.targetType = CellType.Block;
        }

        private void heatSourceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (heatSourceRadioBtn.Checked)
                mesh.targetType = CellType.HeatSource;
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
        }

        private void windowRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (windowRadioBtn.Checked)
                mesh.targetType = CellType.Window;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (startBtn.Text == "Start") startBtn.Text = "Stop";
            else startBtn.Text = "Start";

            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;

            _worker.DoWork += new DoWorkEventHandler((state, args) =>
            {
                do
                {
                    if (_worker.CancellationPending || startBtn.Text == "Start")
                        break;

                    mesh.Update(mode);
                    simpleOpenGlControl1.Invalidate();
                } while (true);
            });
            _worker.RunWorkerAsync();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //not a final version
            int n;
            bool isNumeric = int.TryParse(sideTxt.Text, out n);
            if (!isNumeric)
            {
                MessageBox.Show("Value is not Numeric");
                return;
            }
            CellType tmp = mesh.targetType;
            mesh = new Mesh(width, height, n);
            mesh.targetType = tmp;
            simpleOpenGlControl1.Refresh();
        }

        private void simpleOpenGlControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                int row = y / mesh.cellsize, col = x / mesh.cellsize;
                row = Math.Max(0, Math.Min(mesh.rows - 1, row));
                col = Math.Max(0, Math.Min(mesh.cols - 1, col));
                mesh.ChangeCell(row, col);
                simpleOpenGlControl1.Refresh();
            }
        }

        private void parallelModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (parallelModeCheckBox.Checked == true) mode = Mode.Parallel;
            else mode = Mode.Serial;
        }
    }
}
