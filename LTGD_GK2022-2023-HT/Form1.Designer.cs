namespace LTGD_GK2022_2023
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemGK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiemCK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeSoGK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeSoCK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDiemQuaMon = new System.Windows.Forms.Label();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbDiemTongQuat = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbDiemChu = new System.Windows.Forms.Label();
            this.errorHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorKhoa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDiemGK = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDiemCK = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiemGK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiemCK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên sinh viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(259, 29);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(234, 38);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.TxtHoTen_Validating);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khóa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(259, 99);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(234, 38);
            this.txtKhoa.TabIndex = 1;
            this.txtKhoa.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtKhoa.Validating += new System.ComponentModel.CancelEventHandler(this.TxtKhoa_Validating);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm giữa kỳ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiemGK
            // 
            this.txtDiemGK.Location = new System.Drawing.Point(259, 169);
            this.txtDiemGK.Name = "txtDiemGK";
            this.txtDiemGK.Size = new System.Drawing.Size(234, 38);
            this.txtDiemGK.TabIndex = 2;
            this.txtDiemGK.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtDiemGK.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDiem_Validating);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm cuối kỳ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiemCK
            // 
            this.txtDiemCK.Location = new System.Drawing.Point(259, 239);
            this.txtDiemCK.Name = "txtDiemCK";
            this.txtDiemCK.Size = new System.Drawing.Size(234, 38);
            this.txtDiemCK.TabIndex = 3;
            this.txtDiemCK.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtDiemCK.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDiem_Validating);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hệ số giữa kỳ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHeSoGK
            // 
            this.txtHeSoGK.Enabled = false;
            this.txtHeSoGK.Location = new System.Drawing.Point(259, 309);
            this.txtHeSoGK.Name = "txtHeSoGK";
            this.txtHeSoGK.Size = new System.Drawing.Size(234, 38);
            this.txtHeSoGK.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(37, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hệ số cuối kỳ:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHeSoCK
            // 
            this.txtHeSoCK.Enabled = false;
            this.txtHeSoCK.Location = new System.Drawing.Point(259, 379);
            this.txtHeSoCK.Name = "txtHeSoCK";
            this.txtHeSoCK.Size = new System.Drawing.Size(234, 38);
            this.txtHeSoCK.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mức điểm phải đạt để qua môn:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(499, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 38);
            this.label8.TabIndex = 3;
            this.label8.Text = "%";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(499, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 38);
            this.label9.TabIndex = 3;
            this.label9.Text = "%";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiemQuaMon
            // 
            this.lbDiemQuaMon.Location = new System.Drawing.Point(432, 496);
            this.lbDiemQuaMon.Name = "lbDiemQuaMon";
            this.lbDiemQuaMon.Size = new System.Drawing.Size(38, 38);
            this.lbDiemQuaMon.TabIndex = 3;
            this.lbDiemQuaMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.Enabled = false;
            this.btnTinhDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhDiem.Location = new System.Drawing.Point(543, 309);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(108, 108);
            this.btnTinhDiem.TabIndex = 4;
            this.btnTinhDiem.Text = "Tính điểm";
            this.btnTinhDiem.UseVisualStyleBackColor = true;
            this.btnTinhDiem.Click += new System.EventHandler(this.BtnTinhDiem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(657, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 31);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kết quả học tập";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(657, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "Điểm tổng quát:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(657, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 31);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kết quả:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(657, 492);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 31);
            this.label13.TabIndex = 5;
            this.label13.Text = "Điểm chữ:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(866, 309);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(101, 31);
            this.lbHoTen.TabIndex = 6;
            this.lbHoTen.Text = "label14";
            this.lbHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDiemTongQuat
            // 
            this.lbDiemTongQuat.AutoSize = true;
            this.lbDiemTongQuat.Location = new System.Drawing.Point(868, 370);
            this.lbDiemTongQuat.Name = "lbDiemTongQuat";
            this.lbDiemTongQuat.Size = new System.Drawing.Size(101, 31);
            this.lbDiemTongQuat.TabIndex = 6;
            this.lbDiemTongQuat.Text = "label14";
            this.lbDiemTongQuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(778, 431);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(101, 31);
            this.lbKetQua.TabIndex = 6;
            this.lbKetQua.Text = "label14";
            this.lbKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDiemChu
            // 
            this.lbDiemChu.AutoSize = true;
            this.lbDiemChu.Location = new System.Drawing.Point(799, 492);
            this.lbDiemChu.Name = "lbDiemChu";
            this.lbDiemChu.Size = new System.Drawing.Size(101, 31);
            this.lbDiemChu.TabIndex = 6;
            this.lbDiemChu.Text = "label14";
            this.lbDiemChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorHoTen
            // 
            this.errorHoTen.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorHoTen.ContainerControl = this;
            // 
            // errorKhoa
            // 
            this.errorKhoa.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorKhoa.ContainerControl = this;
            // 
            // errorDiemGK
            // 
            this.errorDiemGK.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDiemGK.ContainerControl = this;
            // 
            // errorDiemCK
            // 
            this.errorDiemCK.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDiemCK.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 586);
            this.Controls.Add(this.lbDiemChu);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbDiemTongQuat);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnTinhDiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDiemQuaMon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHeSoCK);
            this.Controls.Add(this.txtHeSoGK);
            this.Controls.Add(this.txtDiemCK);
            this.Controls.Add(this.txtDiemGK);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiemGK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiemCK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemGK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiemCK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHeSoGK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeSoCK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDiemQuaMon;
        private System.Windows.Forms.Button btnTinhDiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbDiemTongQuat;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbDiemChu;
        private System.Windows.Forms.ErrorProvider errorHoTen;
        private System.Windows.Forms.ErrorProvider errorKhoa;
        private System.Windows.Forms.ErrorProvider errorDiemGK;
        private System.Windows.Forms.ErrorProvider errorDiemCK;
    }
}

