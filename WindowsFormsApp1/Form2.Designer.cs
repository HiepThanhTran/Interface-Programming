namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMayTinh = new System.Windows.Forms.TextBox();
            this.txtMayLanh = new System.Windows.Forms.TextBox();
            this.txtSoDen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMayTinh);
            this.groupBox1.Controls.Add(this.txtMayLanh);
            this.groupBox1.Controls.Add(this.txtSoDen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các thiết bị trong phòng";
            // 
            // txtMayTinh
            // 
            this.txtMayTinh.Location = new System.Drawing.Point(203, 150);
            this.txtMayTinh.Name = "txtMayTinh";
            this.txtMayTinh.Size = new System.Drawing.Size(100, 31);
            this.txtMayTinh.TabIndex = 1;
            this.txtMayTinh.Text = "1";
            this.txtMayTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMayLanh
            // 
            this.txtMayLanh.Location = new System.Drawing.Point(203, 95);
            this.txtMayLanh.Name = "txtMayLanh";
            this.txtMayLanh.Size = new System.Drawing.Size(100, 31);
            this.txtMayLanh.TabIndex = 1;
            this.txtMayLanh.Text = "1";
            this.txtMayLanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSoDen
            // 
            this.txtSoDen.Location = new System.Drawing.Point(203, 40);
            this.txtSoDen.Name = "txtSoDen";
            this.txtSoDen.Size = new System.Drawing.Size(100, 31);
            this.txtSoDen.TabIndex = 1;
            this.txtSoDen.Text = "1";
            this.txtSoDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số máy tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số máy lạnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số đèn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(393, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 220);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính kW tiêu thụ và tiền điện";
            // 
            // txtTien
            // 
            this.txtTien.Enabled = false;
            this.txtTien.Location = new System.Drawing.Point(275, 123);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(100, 31);
            this.txtTien.TabIndex = 1;
            this.txtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện năng tiêu thụ (kW)";
            // 
            // txtDien
            // 
            this.txtDien.Enabled = false;
            this.txtDien.Location = new System.Drawing.Point(275, 66);
            this.txtDien.Name = "txtDien";
            this.txtDien.Size = new System.Drawing.Size(100, 31);
            this.txtDien.TabIndex = 1;
            this.txtDien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số tiền (VNĐ)";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(275, 246);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(117, 43);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.BtnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(421, 246);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 43);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 296);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMayTinh;
        private System.Windows.Forms.TextBox txtMayLanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
    }
}