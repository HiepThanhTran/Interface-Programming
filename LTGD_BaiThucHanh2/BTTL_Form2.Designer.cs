namespace LTGD_BaiThucHanh2
{
    partial class BTTL_Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTTL_Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(174, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình giải phương trình bậc 2";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(160, 157);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(74, 39);
            this.lbA.TabIndex = 1;
            this.lbA.Text = "a = ";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(231, 154);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 45);
            this.txtA.TabIndex = 0;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(380, 157);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(74, 39);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "b = ";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(451, 154);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 45);
            this.txtB.TabIndex = 1;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(618, 154);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(72, 39);
            this.lbC.TabIndex = 1;
            this.lbC.Text = "c = ";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(689, 151);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 45);
            this.txtC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(225, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKetQua.Location = new System.Drawing.Point(365, 255);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(358, 105);
            this.lbKetQua.TabIndex = 4;
            this.lbKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(260, 377);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(149, 59);
            this.btnGiai.TabIndex = 3;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(540, 377);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(149, 59);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(949, 471);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHƯƠNG  TRÌNH BẬC 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnDong;
    }
}