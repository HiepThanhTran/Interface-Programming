namespace LTGD_BaiThucHanh5
{
    partial class BTTL_Form1
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
            this.pctBall = new System.Windows.Forms.PictureBox();
            this.lbCrossBar = new System.Windows.Forms.Label();
            this.timerBall = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBall
            // 
            this.pctBall.InitialImage = null;
            this.pctBall.Location = new System.Drawing.Point(442, 38);
            this.pctBall.Name = "pctBall";
            this.pctBall.Size = new System.Drawing.Size(50, 50);
            this.pctBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBall.TabIndex = 1;
            this.pctBall.TabStop = false;
            // 
            // lbCrossBar
            // 
            this.lbCrossBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbCrossBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCrossBar.Location = new System.Drawing.Point(384, 404);
            this.lbCrossBar.Name = "lbCrossBar";
            this.lbCrossBar.Size = new System.Drawing.Size(166, 19);
            this.lbCrossBar.TabIndex = 2;
            this.lbCrossBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCrossBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LbCrossBar_MouseDown);
            this.lbCrossBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LbCrossBar_MouseMove);
            // 
            // timerBall
            // 
            this.timerBall.Interval = 20;
            this.timerBall.Tick += new System.EventHandler(this.TimerBall_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 529);
            this.Controls.Add(this.lbCrossBar);
            this.Controls.Add(this.pctBall);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBall;
        private System.Windows.Forms.Label lbCrossBar;
        private System.Windows.Forms.Timer timerBall;
    }
}