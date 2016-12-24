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
            InitializeValues();
        }

        void InitializeValues()
        {
            height = simpleOpenGlControl1.Height;
            width = simpleOpenGlControl1.Width;
            simpleOpenGlControl1.InitializeContexts();
            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(0, width, height, 0);

            mode = Mode.Serial;
            mesh = new Mesh(width, height, 20);
            mesh.targetType = CellType.Block;
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

        private bool CheckConsistency()
        {
            if (parallelCppModeRadioBtn.Checked == true && n_threadsTxtBox.Text.Length == 0) return false;
            return true;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (CheckConsistency() == false)
            {
                MessageBox.Show("Please Enter Number of Threads.");
                return;
            }

            UpdateStartButton();
            StartWorker();
        }

        private void StartWorker()
        {
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

        private void UpdateStartButton()
        {
            if (startBtn.Text == "Start") startBtn.Text = "Stop";
            else startBtn.Text = "Start";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int size = 0;
            bool isNumeric = int.TryParse(sideTxt.Text, out size);
            if (!isNumeric)
            {
                MessageBox.Show("Value is not Numeric.");
                return;
            }
            UpdateStartButton();
            CellType tmp = mesh.targetType;
            mesh = new Mesh(width, height, size);
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

        private void parallelCppModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (parallelCppModeRadioBtn.Checked == true)
            {
                threadsLabel.Visible = n_threadsTxtBox.Visible = true;
                mode = Mode.ParallelOmp;
            }
        }

        private void serialModeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (serialModeRadioBtn.Checked == true)
            {
                threadsLabel.Visible = n_threadsTxtBox.Visible = false;
                mode = Mode.Serial;
            }
        }

        private void parallelCSRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (parallelCSRadioBtn.Checked == true)
            {
                threadsLabel.Visible = n_threadsTxtBox.Visible = false;
                mode = Mode.Parallel;
            }
        }

        private void n_threadsTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (n_threadsTxtBox.Text.Length == 0)
                return;
            TemperatureFlow.num_threads = int.Parse(n_threadsTxtBox.Text);
        }

        private void UpdateMinMax_Click(object sender, EventArgs e)
        {
            if (_worker != null && _worker.IsBusy)
            {
                _worker.CancelAsync();
            }
            mesh.UpdateCurrentMesh();
            if (startBtn.Text == "Stop")
            {
                StartWorker();
            }
        }
    }
}