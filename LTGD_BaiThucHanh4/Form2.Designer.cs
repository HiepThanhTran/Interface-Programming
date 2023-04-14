namespace LTGD_BaiThucHanh4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbPoint = new System.Windows.Forms.Label();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pctDice1 = new System.Windows.Forms.PictureBox();
            this.pctDice2 = new System.Windows.Forms.PictureBox();
            this.pctDice3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.scrollTimer = new System.Windows.Forms.Timer(this.components);
            this.diceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPoint
            // 
            this.lbPoint.BackColor = System.Drawing.Color.Blue;
            this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.ForeColor = System.Drawing.Color.White;
            this.lbPoint.Location = new System.Drawing.Point(350, 349);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(169, 55);
            this.lbPoint.TabIndex = 1;
            this.lbPoint.Text = "0";
            this.lbPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.Color.Blue;
            this.btnSpin.Location = new System.Drawing.Point(263, 432);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(149, 45);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.Text = "Quay số";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(456, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pctDice1
            // 
            this.pctDice1.Location = new System.Drawing.Point(63, 142);
            this.pctDice1.Name = "pctDice1";
            this.pctDice1.Size = new System.Drawing.Size(169, 168);
            this.pctDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDice1.TabIndex = 2;
            this.pctDice1.TabStop = false;
            // 
            // pctDice2
            // 
            this.pctDice2.Location = new System.Drawing.Point(350, 142);
            this.pctDice2.Name = "pctDice2";
            this.pctDice2.Size = new System.Drawing.Size(169, 168);
            this.pctDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDice2.TabIndex = 2;
            this.pctDice2.TabStop = false;
            // 
            // pctDice3
            // 
            this.pctDice3.Location = new System.Drawing.Point(637, 142);
            this.pctDice3.Name = "pctDice3";
            this.pctDice3.Size = new System.Drawing.Size(169, 168);
            this.pctDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDice3.TabIndex = 2;
            this.pctDice3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 100);
            this.panel1.TabIndex = 4;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Blue;
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTitle.Size = new System.Drawing.Size(869, 100);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "     2151050469 - Trần Thanh Hiệp     ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollTimer
            // 
            this.scrollTimer.Enabled = true;
            this.scrollTimer.Interval = 200;
            this.scrollTimer.Tick += new System.EventHandler(this.ScrollTimer_Tick);
            // 
            // diceTimer
            // 
            this.diceTimer.Tick += new System.EventHandler(this.DiceTimer_Tick);
            // 
            // Form2
            // 
            this.AcceptButton = this.btnSpin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(869, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.pctDice3);
            this.Controls.Add(this.pctDice2);
            this.Controls.Add(this.pctDice1);
            this.Controls.Add(this.lbPoint);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quay Xúc Xắc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.PictureBox pctDice1;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctDice2;
        private System.Windows.Forms.PictureBox pctDice3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Timer diceTimer;
        private System.Windows.Forms.Timer scrollTimer;
    }
}