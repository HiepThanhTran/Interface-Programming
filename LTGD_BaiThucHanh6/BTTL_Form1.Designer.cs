namespace LTGD_BaiThucHanh6
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colArrInitial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSumEven = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSumOdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateArr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.lbArrInitial = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colArrInitial,
            this.colSumEven,
            this.colSumOdd,
            this.colAvg,
            this.colPrime});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 251);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1345, 420);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView1_ColumnWidthChanging);
            // 
            // colArrInitial
            // 
            this.colArrInitial.Text = "Mảng ban đầu";
            this.colArrInitial.Width = 330;
            // 
            // colSumEven
            // 
            this.colSumEven.Text = "Tổng các số chẵn";
            this.colSumEven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSumEven.Width = 230;
            // 
            // colSumOdd
            // 
            this.colSumOdd.Text = "Tổng các số lẻ";
            this.colSumOdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSumOdd.Width = 200;
            // 
            // colAvg
            // 
            this.colAvg.Text = "Trung bình cộng";
            this.colAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAvg.Width = 220;
            // 
            // colPrime
            // 
            this.colPrime.Text = "Các số nguyên tố";
            this.colPrime.Width = 330;
            // 
            // btnCreateArr
            // 
            this.btnCreateArr.Location = new System.Drawing.Point(485, 167);
            this.btnCreateArr.Name = "btnCreateArr";
            this.btnCreateArr.Size = new System.Drawing.Size(191, 65);
            this.btnCreateArr.TabIndex = 1;
            this.btnCreateArr.Text = "Tạo mảng";
            this.btnCreateArr.UseVisualStyleBackColor = true;
            this.btnCreateArr.Click += new System.EventHandler(this.BtnCreateArr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số phần tử:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(729, 22);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 45);
            this.txtAmount.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtAmount, "Bấm Enter để tạo mảng và thống kê");
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAmount_KeyDown);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(692, 167);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(191, 65);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // lbArrInitial
            // 
            this.lbArrInitial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbArrInitial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbArrInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrInitial.Location = new System.Drawing.Point(485, 85);
            this.lbArrInitial.Name = "lbArrInitial";
            this.lbArrInitial.Size = new System.Drawing.Size(398, 60);
            this.lbArrInitial.TabIndex = 5;
            this.lbArrInitial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Gợi ý";
            // 
            // BTTL_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1369, 683);
            this.Controls.Add(this.lbArrInitial);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateArr);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BTTL_Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê mảng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colArrInitial;
        private System.Windows.Forms.ColumnHeader colSumEven;
        private System.Windows.Forms.ColumnHeader colSumOdd;
        private System.Windows.Forms.ColumnHeader colAvg;
        private System.Windows.Forms.ColumnHeader colPrime;
        private System.Windows.Forms.Button btnCreateArr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label lbArrInitial;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}