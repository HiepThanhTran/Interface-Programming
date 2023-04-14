namespace LTGD_BaiThucHanh8
{
    partial class BTTL_Form2_Option
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTriangle = new System.Windows.Forms.RadioButton();
            this.rdEllipse = new System.Windows.Forms.RadioButton();
            this.rdRectangle = new System.Windows.Forms.RadioButton();
            this.lbColor = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTriangle);
            this.groupBox1.Controls.Add(this.rdEllipse);
            this.groupBox1.Controls.Add(this.rdRectangle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rdTriangle
            // 
            this.rdTriangle.AutoSize = true;
            this.rdTriangle.Location = new System.Drawing.Point(178, 139);
            this.rdTriangle.Name = "rdTriangle";
            this.rdTriangle.Size = new System.Drawing.Size(124, 33);
            this.rdTriangle.TabIndex = 0;
            this.rdTriangle.Text = "Triangle";
            this.rdTriangle.UseVisualStyleBackColor = true;
            // 
            // rdEllipse
            // 
            this.rdEllipse.AutoSize = true;
            this.rdEllipse.Location = new System.Drawing.Point(178, 90);
            this.rdEllipse.Name = "rdEllipse";
            this.rdEllipse.Size = new System.Drawing.Size(108, 33);
            this.rdEllipse.TabIndex = 0;
            this.rdEllipse.Text = "Ellipse";
            this.rdEllipse.UseVisualStyleBackColor = true;
            // 
            // rdRectangle
            // 
            this.rdRectangle.AutoSize = true;
            this.rdRectangle.Checked = true;
            this.rdRectangle.Location = new System.Drawing.Point(178, 41);
            this.rdRectangle.Name = "rdRectangle";
            this.rdRectangle.Size = new System.Drawing.Size(143, 33);
            this.rdRectangle.TabIndex = 0;
            this.rdRectangle.TabStop = true;
            this.rdRectangle.Text = "Rectangle";
            this.rdRectangle.UseVisualStyleBackColor = true;
            // 
            // lbColor
            // 
            this.lbColor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbColor.Location = new System.Drawing.Point(12, 235);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(498, 36);
            this.lbColor.TabIndex = 1;
            this.lbColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbColor.Click += new System.EventHandler(this.LbColor_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(92, 285);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(143, 44);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(288, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 44);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BTTL_Form2_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BTTL_Form2_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.BTTL_Form2_Option_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdRectangle;
        private System.Windows.Forms.RadioButton rdTriangle;
        private System.Windows.Forms.RadioButton rdEllipse;
    }
}