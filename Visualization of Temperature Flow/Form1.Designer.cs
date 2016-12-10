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
            this.blockRadioBtn = new System.Windows.Forms.RadioButton();
            this.heatSourceRadioBtn = new System.Windows.Forms.RadioButton();
            this.coldSourceRadioBtn = new System.Windows.Forms.RadioButton();
            this.normalCellRadioBtn = new System.Windows.Forms.RadioButton();
            this.windowRadioBtn = new System.Windows.Forms.RadioButton();
            this.sideTxt = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(12, 12);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(1385, 1011);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
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
            this.panelControl.Location = new System.Drawing.Point(1419, 22);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(409, 264);
            this.panelControl.TabIndex = 1;
            this.panelControl.TabStop = false;
            this.panelControl.Text = "Panel Control";
            // 
            // blockRadioBtn
            // 
            this.blockRadioBtn.AutoSize = true;
            this.blockRadioBtn.Location = new System.Drawing.Point(6, 58);
            this.blockRadioBtn.Name = "blockRadioBtn";
            this.blockRadioBtn.Size = new System.Drawing.Size(96, 29);
            this.blockRadioBtn.TabIndex = 0;
            this.blockRadioBtn.TabStop = true;
            this.blockRadioBtn.Text = "Block";
            this.blockRadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blockRadioBtn.UseVisualStyleBackColor = true;
            // 
            // heatSourceRadioBtn
            // 
            this.heatSourceRadioBtn.AutoSize = true;
            this.heatSourceRadioBtn.Location = new System.Drawing.Point(6, 93);
            this.heatSourceRadioBtn.Name = "heatSourceRadioBtn";
            this.heatSourceRadioBtn.Size = new System.Drawing.Size(162, 29);
            this.heatSourceRadioBtn.TabIndex = 1;
            this.heatSourceRadioBtn.TabStop = true;
            this.heatSourceRadioBtn.Text = "Heat Source";
            this.heatSourceRadioBtn.UseVisualStyleBackColor = true;
            // 
            // coldSourceRadioBtn
            // 
            this.coldSourceRadioBtn.AutoSize = true;
            this.coldSourceRadioBtn.Location = new System.Drawing.Point(6, 128);
            this.coldSourceRadioBtn.Name = "coldSourceRadioBtn";
            this.coldSourceRadioBtn.Size = new System.Drawing.Size(161, 29);
            this.coldSourceRadioBtn.TabIndex = 2;
            this.coldSourceRadioBtn.TabStop = true;
            this.coldSourceRadioBtn.Text = "Cold Source";
            this.coldSourceRadioBtn.UseVisualStyleBackColor = true;
            // 
            // normalCellRadioBtn
            // 
            this.normalCellRadioBtn.AutoSize = true;
            this.normalCellRadioBtn.Location = new System.Drawing.Point(6, 163);
            this.normalCellRadioBtn.Name = "normalCellRadioBtn";
            this.normalCellRadioBtn.Size = new System.Drawing.Size(154, 29);
            this.normalCellRadioBtn.TabIndex = 3;
            this.normalCellRadioBtn.TabStop = true;
            this.normalCellRadioBtn.Text = "Normal Cell";
            this.normalCellRadioBtn.UseVisualStyleBackColor = true;
            // 
            // windowRadioBtn
            // 
            this.windowRadioBtn.AutoSize = true;
            this.windowRadioBtn.Location = new System.Drawing.Point(6, 198);
            this.windowRadioBtn.Name = "windowRadioBtn";
            this.windowRadioBtn.Size = new System.Drawing.Size(119, 29);
            this.windowRadioBtn.TabIndex = 4;
            this.windowRadioBtn.TabStop = true;
            this.windowRadioBtn.Text = "Window";
            this.windowRadioBtn.UseVisualStyleBackColor = true;
            // 
            // sideTxt
            // 
            this.sideTxt.Location = new System.Drawing.Point(329, 58);
            this.sideTxt.Name = "sideTxt";
            this.sideTxt.Size = new System.Drawing.Size(74, 31);
            this.sideTxt.TabIndex = 5;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(1694, 292);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(128, 50);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(275, 95);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(128, 50);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Side:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 1035);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

