namespace LTGD_BaiTapNhomL3
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
            this.components = new System.ComponentModel.Container();
            this.pct = new System.Windows.Forms.PictureBox();
            this.lbRed = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbBlue = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbColorChange = new System.Windows.Forms.Label();
            this.ckbRed = new System.Windows.Forms.CheckBox();
            this.ckbGreen = new System.Windows.Forms.CheckBox();
            this.ckbBlue = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pct
            // 
            this.pct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pct.Location = new System.Drawing.Point(484, 41);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(756, 626);
            this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct.TabIndex = 0;
            this.pct.TabStop = false;
            // 
            // lbRed
            // 
            this.lbRed.BackColor = System.Drawing.Color.Red;
            this.lbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRed.Location = new System.Drawing.Point(39, 185);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(60, 60);
            this.lbRed.TabIndex = 1;
            this.lbRed.Text = "255";
            this.lbRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGreen
            // 
            this.lbGreen.BackColor = System.Drawing.Color.Lime;
            this.lbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbGreen.Location = new System.Drawing.Point(205, 185);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(60, 60);
            this.lbGreen.TabIndex = 1;
            this.lbGreen.Text = "255";
            this.lbGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBlue
            // 
            this.lbBlue.BackColor = System.Drawing.Color.Blue;
            this.lbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBlue.Location = new System.Drawing.Point(371, 185);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(60, 60);
            this.lbBlue.TabIndex = 1;
            this.lbBlue.Text = "255";
            this.lbBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(39, 262);
            this.vScrollBar1.Maximum = 255;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(60, 331);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.VScrollBar1_ValueChanged);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.LargeChange = 1;
            this.vScrollBar2.Location = new System.Drawing.Point(205, 262);
            this.vScrollBar2.Maximum = 255;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(60, 331);
            this.vScrollBar2.TabIndex = 2;
            this.vScrollBar2.ValueChanged += new System.EventHandler(this.VScrollBar1_ValueChanged);
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.LargeChange = 1;
            this.vScrollBar3.Location = new System.Drawing.Point(371, 262);
            this.vScrollBar3.Maximum = 255;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(60, 331);
            this.vScrollBar3.TabIndex = 2;
            this.vScrollBar3.ValueChanged += new System.EventHandler(this.VScrollBar1_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // lbColorChange
            // 
            this.lbColorChange.BackColor = System.Drawing.Color.White;
            this.lbColorChange.Location = new System.Drawing.Point(39, 51);
            this.lbColorChange.Name = "lbColorChange";
            this.lbColorChange.Size = new System.Drawing.Size(392, 117);
            this.lbColorChange.TabIndex = 4;
            // 
            // ckbRed
            // 
            this.ckbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRed.Location = new System.Drawing.Point(17, 612);
            this.ckbRed.Name = "ckbRed";
            this.ckbRed.Size = new System.Drawing.Size(104, 55);
            this.ckbRed.TabIndex = 5;
            this.ckbRed.Text = "Auto";
            this.ckbRed.UseVisualStyleBackColor = true;
            // 
            // ckbGreen
            // 
            this.ckbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGreen.Location = new System.Drawing.Point(183, 612);
            this.ckbGreen.Name = "ckbGreen";
            this.ckbGreen.Size = new System.Drawing.Size(104, 55);
            this.ckbGreen.TabIndex = 5;
            this.ckbGreen.Text = "Auto";
            this.ckbGreen.UseVisualStyleBackColor = true;
            // 
            // ckbBlue
            // 
            this.ckbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBlue.Location = new System.Drawing.Point(349, 612);
            this.ckbBlue.Name = "ckbBlue";
            this.ckbBlue.Size = new System.Drawing.Size(104, 55);
            this.ckbBlue.TabIndex = 5;
            this.ckbBlue.Text = "Auto";
            this.ckbBlue.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1252, 672);
            this.Controls.Add(this.ckbBlue);
            this.Controls.Add(this.ckbGreen);
            this.Controls.Add(this.ckbRed);
            this.Controls.Add(this.lbColorChange);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lbBlue);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbBlue;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lbColorChange;
        private System.Windows.Forms.CheckBox ckbRed;
        private System.Windows.Forms.CheckBox ckbGreen;
        private System.Windows.Forms.CheckBox ckbBlue;
        private System.Windows.Forms.Timer timer1;
    }
}

