namespace LTGD_BaiThucHanh2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTTL_Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.btnASCII = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbASCII = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKyTu = new System.Windows.Forms.TextBox();
            this.btnKyTu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbKyTu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1083, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN MÃ ASCII";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbASCII);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnASCII);
            this.groupBox1.Controls.Add(this.txtASCII);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển mã ASCII sang ký tự";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbKyTu);
            this.groupBox2.Controls.Add(this.txtKyTu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnKyTu);
            this.groupBox2.Location = new System.Drawing.Point(574, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 264);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyển ký tự sang mã ASCII";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ASCII";
            // 
            // txtASCII
            // 
            this.txtASCII.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASCII.Location = new System.Drawing.Point(264, 60);
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(143, 41);
            this.txtASCII.TabIndex = 0;
            // 
            // btnASCII
            // 
            this.btnASCII.Location = new System.Drawing.Point(264, 115);
            this.btnASCII.Name = "btnASCII";
            this.btnASCII.Size = new System.Drawing.Size(143, 47);
            this.btnASCII.TabIndex = 1;
            this.btnASCII.Text = "Chuyển";
            this.btnASCII.UseVisualStyleBackColor = true;
            this.btnASCII.Click += new System.EventHandler(this.btnASCII_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả";
            // 
            // lbASCII
            // 
            this.lbASCII.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbASCII.Location = new System.Drawing.Point(264, 176);
            this.lbASCII.Name = "lbASCII";
            this.lbASCII.Size = new System.Drawing.Size(143, 38);
            this.lbASCII.TabIndex = 4;
            this.lbASCII.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ký tự";
            // 
            // txtKyTu
            // 
            this.txtKyTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyTu.Location = new System.Drawing.Point(264, 60);
            this.txtKyTu.Name = "txtKyTu";
            this.txtKyTu.Size = new System.Drawing.Size(143, 41);
            this.txtKyTu.TabIndex = 0;
            // 
            // btnKyTu
            // 
            this.btnKyTu.Location = new System.Drawing.Point(264, 115);
            this.btnKyTu.Name = "btnKyTu";
            this.btnKyTu.Size = new System.Drawing.Size(143, 47);
            this.btnKyTu.TabIndex = 1;
            this.btnKyTu.Text = "Chuyển";
            this.btnKyTu.UseVisualStyleBackColor = true;
            this.btnKyTu.Click += new System.EventHandler(this.btnKyTu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kết quả";
            // 
            // lbKyTu
            // 
            this.lbKyTu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKyTu.Location = new System.Drawing.Point(264, 176);
            this.lbKyTu.Name = "lbKyTu";
            this.lbKyTu.Size = new System.Drawing.Size(143, 38);
            this.lbKyTu.TabIndex = 4;
            this.lbKyTu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(3, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(478, 42);
            this.label6.TabIndex = 5;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(3, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(478, 38);
            this.label7.TabIndex = 5;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1083, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển mã ASCII";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbASCII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnASCII;
        private System.Windows.Forms.TextBox txtASCII;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbKyTu;
        private System.Windows.Forms.TextBox txtKyTu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKyTu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}