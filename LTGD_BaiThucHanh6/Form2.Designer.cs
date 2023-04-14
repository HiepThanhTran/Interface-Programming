namespace LTGD_BaiThucHanh6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbArrEvenOdd = new System.Windows.Forms.Label();
            this.btnCreateArr = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lbArrReverse = new System.Windows.Forms.Label();
            this.lbArrDescending = new System.Windows.Forms.Label();
            this.lbArrAscending = new System.Windows.Forms.Label();
            this.lbArrInitial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phần tử:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(177, 16);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 38);
            this.txtAmount.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mảng ban đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mảng tăng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mảng giảm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mảng đảo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mảng chẵn tăng, lẻ giảm:";
            // 
            // lbArrEvenOdd
            // 
            this.lbArrEvenOdd.BackColor = System.Drawing.SystemColors.Control;
            this.lbArrEvenOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrEvenOdd.Location = new System.Drawing.Point(350, 371);
            this.lbArrEvenOdd.Name = "lbArrEvenOdd";
            this.lbArrEvenOdd.Size = new System.Drawing.Size(620, 32);
            this.lbArrEvenOdd.TabIndex = 0;
            // 
            // btnCreateArr
            // 
            this.btnCreateArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateArr.Location = new System.Drawing.Point(350, 12);
            this.btnCreateArr.Name = "btnCreateArr";
            this.btnCreateArr.Size = new System.Drawing.Size(305, 44);
            this.btnCreateArr.TabIndex = 1;
            this.btnCreateArr.Text = "Tạo mảng ngẫu nhiên";
            this.btnCreateArr.UseVisualStyleBackColor = true;
            this.btnCreateArr.Click += new System.EventHandler(this.BtnCreateArr_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(665, 12);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(305, 44);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // lbArrReverse
            // 
            this.lbArrReverse.BackColor = System.Drawing.SystemColors.Control;
            this.lbArrReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrReverse.Location = new System.Drawing.Point(350, 300);
            this.lbArrReverse.Name = "lbArrReverse";
            this.lbArrReverse.Size = new System.Drawing.Size(620, 32);
            this.lbArrReverse.TabIndex = 0;
            // 
            // lbArrDescending
            // 
            this.lbArrDescending.BackColor = System.Drawing.SystemColors.Control;
            this.lbArrDescending.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrDescending.Location = new System.Drawing.Point(350, 229);
            this.lbArrDescending.Name = "lbArrDescending";
            this.lbArrDescending.Size = new System.Drawing.Size(620, 32);
            this.lbArrDescending.TabIndex = 0;
            // 
            // lbArrAscending
            // 
            this.lbArrAscending.BackColor = System.Drawing.SystemColors.Control;
            this.lbArrAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrAscending.Location = new System.Drawing.Point(350, 158);
            this.lbArrAscending.Name = "lbArrAscending";
            this.lbArrAscending.Size = new System.Drawing.Size(620, 32);
            this.lbArrAscending.TabIndex = 0;
            // 
            // lbArrInitial
            // 
            this.lbArrInitial.BackColor = System.Drawing.SystemColors.Info;
            this.lbArrInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrInitial.Location = new System.Drawing.Point(350, 87);
            this.lbArrInitial.Name = "lbArrInitial";
            this.lbArrInitial.Size = new System.Drawing.Size(620, 32);
            this.lbArrInitial.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 412);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCreateArr);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbArrInitial);
            this.Controls.Add(this.lbArrAscending);
            this.Controls.Add(this.lbArrDescending);
            this.Controls.Add(this.lbArrReverse);
            this.Controls.Add(this.lbArrEvenOdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sắp xếp mảng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbArrEvenOdd;
        private System.Windows.Forms.Button btnCreateArr;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lbArrReverse;
        private System.Windows.Forms.Label lbArrDescending;
        private System.Windows.Forms.Label lbArrAscending;
        private System.Windows.Forms.Label lbArrInitial;
    }
}