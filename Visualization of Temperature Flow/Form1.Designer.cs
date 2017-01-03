namespace Visualization_of_Temperature_Flow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.panelControl = new System.Windows.Forms.GroupBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sideTxt = new System.Windows.Forms.TextBox();
            this.windowRadioBtn = new System.Windows.Forms.RadioButton();
            this.normalCellRadioBtn = new System.Windows.Forms.RadioButton();
            this.coldSourceRadioBtn = new System.Windows.Forms.RadioButton();
            this.heatSourceRadioBtn = new System.Windows.Forms.RadioButton();
            this.blockRadioBtn = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.n_threadsTxtBox = new System.Windows.Forms.TextBox();
            this.threadsLabel = new System.Windows.Forms.Label();
            this.parallelCSRadioBtn = new System.Windows.Forms.RadioButton();
            this.parallelCppModeRadioBtn = new System.Windows.Forms.RadioButton();
            this.serialModeRadioBtn = new System.Windows.Forms.RadioButton();
            this.UpdateMinMax = new System.Windows.Forms.Button();
            this.colorMappingPanel1 = new Color_Mapping.ColorMappingPanel();
            this.cellInfoTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panelControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSize = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(6, 6);
            this.simpleOpenGlControl1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(800, 602);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            this.simpleOpenGlControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl1_MouseDown);
            this.simpleOpenGlControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl1_MouseMove);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.updateBtn);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.sideTxt);
            this.panelControl.Controls.Add(this.windowRadioBtn);
            this.panelControl.Controls.Add(this.normalCellRadioBtn);
            this.panelControl.Controls.Add(this.coldSourceRadioBtn);
            this.panelControl.Controls.Add(this.heatSourceRadioBtn);
            this.panelControl.Controls.Add(this.blockRadioBtn);
            this.panelControl.Location = new System.Drawing.Point(823, 11);
            this.panelControl.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(2);
            this.panelControl.Size = new System.Drawing.Size(248, 137);
            this.panelControl.TabIndex = 1;
            this.panelControl.TabStop = false;
            this.panelControl.Text = "Panel Control";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(178, 54);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(64, 26);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Side:";
            // 
            // sideTxt
            // 
            this.sideTxt.Location = new System.Drawing.Point(200, 32);
            this.sideTxt.Margin = new System.Windows.Forms.Padding(2);
            this.sideTxt.Name = "sideTxt";
            this.sideTxt.Size = new System.Drawing.Size(39, 20);
            this.sideTxt.TabIndex = 5;
            this.sideTxt.Text = "20";
            // 
            // windowRadioBtn
            // 
            this.windowRadioBtn.AutoSize = true;
            this.windowRadioBtn.Location = new System.Drawing.Point(4, 111);
            this.windowRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.windowRadioBtn.Name = "windowRadioBtn";
            this.windowRadioBtn.Size = new System.Drawing.Size(63, 17);
            this.windowRadioBtn.TabIndex = 4;
            this.windowRadioBtn.Text = "Window";
            this.windowRadioBtn.UseVisualStyleBackColor = true;
            this.windowRadioBtn.CheckedChanged += new System.EventHandler(this.windowRadioBtn_CheckedChanged);
            // 
            // normalCellRadioBtn
            // 
            this.normalCellRadioBtn.AutoSize = true;
            this.normalCellRadioBtn.Location = new System.Drawing.Point(4, 92);
            this.normalCellRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.normalCellRadioBtn.Name = "normalCellRadioBtn";
            this.normalCellRadioBtn.Size = new System.Drawing.Size(78, 17);
            this.normalCellRadioBtn.TabIndex = 3;
            this.normalCellRadioBtn.Text = "Normal Cell";
            this.normalCellRadioBtn.UseVisualStyleBackColor = true;
            this.normalCellRadioBtn.CheckedChanged += new System.EventHandler(this.normalCellRadioBtn_CheckedChanged);
            // 
            // coldSourceRadioBtn
            // 
            this.coldSourceRadioBtn.AutoSize = true;
            this.coldSourceRadioBtn.Location = new System.Drawing.Point(4, 73);
            this.coldSourceRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.coldSourceRadioBtn.Name = "coldSourceRadioBtn";
            this.coldSourceRadioBtn.Size = new System.Drawing.Size(82, 17);
            this.coldSourceRadioBtn.TabIndex = 2;
            this.coldSourceRadioBtn.Text = "Cold Source";
            this.coldSourceRadioBtn.UseVisualStyleBackColor = true;
            this.coldSourceRadioBtn.CheckedChanged += new System.EventHandler(this.coldSourceRadioBtn_CheckedChanged);
            // 
            // heatSourceRadioBtn
            // 
            this.heatSourceRadioBtn.AutoSize = true;
            this.heatSourceRadioBtn.Location = new System.Drawing.Point(4, 54);
            this.heatSourceRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.heatSourceRadioBtn.Name = "heatSourceRadioBtn";
            this.heatSourceRadioBtn.Size = new System.Drawing.Size(84, 17);
            this.heatSourceRadioBtn.TabIndex = 1;
            this.heatSourceRadioBtn.Text = "Heat Source";
            this.heatSourceRadioBtn.UseVisualStyleBackColor = true;
            this.heatSourceRadioBtn.CheckedChanged += new System.EventHandler(this.heatSourceRadioBtn_CheckedChanged);
            // 
            // blockRadioBtn
            // 
            this.blockRadioBtn.AutoSize = true;
            this.blockRadioBtn.Checked = true;
            this.blockRadioBtn.Location = new System.Drawing.Point(4, 34);
            this.blockRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.blockRadioBtn.Name = "blockRadioBtn";
            this.blockRadioBtn.Size = new System.Drawing.Size(49, 17);
            this.blockRadioBtn.TabIndex = 0;
            this.blockRadioBtn.TabStop = true;
            this.blockRadioBtn.Text = "Block";
            this.blockRadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blockRadioBtn.UseVisualStyleBackColor = true;
            this.blockRadioBtn.CheckedChanged += new System.EventHandler(this.blockRadioBtn_CheckedChanged);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(1001, 257);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(64, 26);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.n_threadsTxtBox);
            this.groupBox1.Controls.Add(this.threadsLabel);
            this.groupBox1.Controls.Add(this.parallelCSRadioBtn);
            this.groupBox1.Controls.Add(this.parallelCppModeRadioBtn);
            this.groupBox1.Controls.Add(this.serialModeRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(823, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(248, 97);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Running Mode";
            // 
            // n_threadsTxtBox
            // 
            this.n_threadsTxtBox.Location = new System.Drawing.Point(200, 45);
            this.n_threadsTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.n_threadsTxtBox.Name = "n_threadsTxtBox";
            this.n_threadsTxtBox.Size = new System.Drawing.Size(39, 20);
            this.n_threadsTxtBox.TabIndex = 8;
            this.n_threadsTxtBox.Text = "5";
            this.n_threadsTxtBox.Visible = false;
            this.n_threadsTxtBox.TextChanged += new System.EventHandler(this.n_threadsTxtBox_TextChanged);
            // 
            // threadsLabel
            // 
            this.threadsLabel.AutoSize = true;
            this.threadsLabel.Location = new System.Drawing.Point(117, 48);
            this.threadsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.threadsLabel.Name = "threadsLabel";
            this.threadsLabel.Size = new System.Drawing.Size(83, 13);
            this.threadsLabel.TabIndex = 3;
            this.threadsLabel.Text = "No. of Threads:";
            this.threadsLabel.Visible = false;
            // 
            // parallelCSRadioBtn
            // 
            this.parallelCSRadioBtn.AutoSize = true;
            this.parallelCSRadioBtn.Location = new System.Drawing.Point(4, 65);
            this.parallelCSRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.parallelCSRadioBtn.Name = "parallelCSRadioBtn";
            this.parallelCSRadioBtn.Size = new System.Drawing.Size(106, 17);
            this.parallelCSRadioBtn.TabIndex = 2;
            this.parallelCSRadioBtn.Text = "Parallel C# Mode";
            this.parallelCSRadioBtn.UseVisualStyleBackColor = true;
            this.parallelCSRadioBtn.CheckedChanged += new System.EventHandler(this.parallelCSRadioBtn_CheckedChanged);
            // 
            // parallelCppModeRadioBtn
            // 
            this.parallelCppModeRadioBtn.AutoSize = true;
            this.parallelCppModeRadioBtn.Location = new System.Drawing.Point(4, 47);
            this.parallelCppModeRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.parallelCppModeRadioBtn.Name = "parallelCppModeRadioBtn";
            this.parallelCppModeRadioBtn.Size = new System.Drawing.Size(114, 17);
            this.parallelCppModeRadioBtn.TabIndex = 1;
            this.parallelCppModeRadioBtn.Text = "Parallel C++ Mode";
            this.parallelCppModeRadioBtn.UseVisualStyleBackColor = true;
            this.parallelCppModeRadioBtn.CheckedChanged += new System.EventHandler(this.parallelCppModeRadioBtn_CheckedChanged);
            // 
            // serialModeRadioBtn
            // 
            this.serialModeRadioBtn.AutoSize = true;
            this.serialModeRadioBtn.Checked = true;
            this.serialModeRadioBtn.Location = new System.Drawing.Point(4, 29);
            this.serialModeRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.serialModeRadioBtn.Name = "serialModeRadioBtn";
            this.serialModeRadioBtn.Size = new System.Drawing.Size(80, 17);
            this.serialModeRadioBtn.TabIndex = 0;
            this.serialModeRadioBtn.TabStop = true;
            this.serialModeRadioBtn.Text = "Serial Mode";
            this.serialModeRadioBtn.UseVisualStyleBackColor = true;
            this.serialModeRadioBtn.CheckedChanged += new System.EventHandler(this.serialModeRadioBtn_CheckedChanged);
            // 
            // UpdateMinMax
            // 
            this.UpdateMinMax.Location = new System.Drawing.Point(972, 420);
            this.UpdateMinMax.Name = "UpdateMinMax";
            this.UpdateMinMax.Size = new System.Drawing.Size(75, 23);
            this.UpdateMinMax.TabIndex = 14;
            this.UpdateMinMax.Text = "Update";
            this.UpdateMinMax.UseVisualStyleBackColor = true;
            this.UpdateMinMax.Click += new System.EventHandler(this.UpdateMinMax_Click);
            // 
            // colorMappingPanel1
            // 
            this.colorMappingPanel1.Location = new System.Drawing.Point(832, 312);
            this.colorMappingPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.colorMappingPanel1.Name = "colorMappingPanel1";
            this.colorMappingPanel1.Size = new System.Drawing.Size(233, 160);
            this.colorMappingPanel1.TabIndex = 12;
            // 
            // cellInfoTP
            // 
            this.cellInfoTP.Location = new System.Drawing.Point(832, 511);
            this.cellInfoTP.Multiline = true;
            this.cellInfoTP.Name = "cellInfoTP";
            this.cellInfoTP.Size = new System.Drawing.Size(125, 66);
            this.cellInfoTP.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cell Info ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Right click to view cell info";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(815, 260);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 18;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(896, 260);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1075, 613);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cellInfoTP);
            this.Controls.Add(this.UpdateMinMax);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.colorMappingPanel1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Visualization of Temperature Flow";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.GroupBox panelControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sideTxt;
        private System.Windows.Forms.RadioButton windowRadioBtn;
        private System.Windows.Forms.RadioButton normalCellRadioBtn;
        private System.Windows.Forms.RadioButton coldSourceRadioBtn;
        private System.Windows.Forms.RadioButton heatSourceRadioBtn;
        private System.Windows.Forms.RadioButton blockRadioBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button updateBtn;
        private Color_Mapping.ColorMappingPanel colorMappingPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton parallelCSRadioBtn;
        private System.Windows.Forms.RadioButton parallelCppModeRadioBtn;
        private System.Windows.Forms.RadioButton serialModeRadioBtn;
        private System.Windows.Forms.Label threadsLabel;
        private System.Windows.Forms.TextBox n_threadsTxtBox;
        private System.Windows.Forms.Button UpdateMinMax;
        private System.Windows.Forms.TextBox cellInfoTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

