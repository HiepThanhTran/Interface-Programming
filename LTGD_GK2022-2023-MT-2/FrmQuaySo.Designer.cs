namespace LTGD_GK2022_2023_MT_2
{
    partial class FrmQuaySo
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
            this.label1 = new System.Windows.Forms.Label();
            this.pctNumber1 = new System.Windows.Forms.PictureBox();
            this.pctNumber2 = new System.Windows.Forms.PictureBox();
            this.pctNumber3 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNumber3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 79);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctNumber1
            // 
            this.pctNumber1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctNumber1.Location = new System.Drawing.Point(29, 132);
            this.pctNumber1.Name = "pctNumber1";
            this.pctNumber1.Size = new System.Drawing.Size(220, 220);
            this.pctNumber1.TabIndex = 1;
            this.pctNumber1.TabStop = false;
            // 
            // pctNumber2
            // 
            this.pctNumber2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctNumber2.Location = new System.Drawing.Point(283, 132);
            this.pctNumber2.Name = "pctNumber2";
            this.pctNumber2.Size = new System.Drawing.Size(220, 220);
            this.pctNumber2.TabIndex = 1;
            this.pctNumber2.TabStop = false;
            // 
            // pctNumber3
            // 
            this.pctNumber3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctNumber3.Location = new System.Drawing.Point(537, 132);
            this.pctNumber3.Name = "pctNumber3";
            this.pctNumber3.Size = new System.Drawing.Size(220, 220);
            this.pctNumber3.TabIndex = 1;
            this.pctNumber3.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(167, 381);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(590, 283);
            this.listBox1.TabIndex = 2;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(29, 457);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(132, 39);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.Text = "Quay số";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.BtnQuaySo_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(29, 534);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 39);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmQuaySo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 676);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pctNumber3);
            this.Controls.Add(this.pctNumber2);
            this.Controls.Add(this.pctNumber1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "FrmQuaySo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quay số";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNumber3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctNumber1;
        private System.Windows.Forms.PictureBox pctNumber2;
        private System.Windows.Forms.PictureBox pctNumber3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Timer timer1;
    }
}

