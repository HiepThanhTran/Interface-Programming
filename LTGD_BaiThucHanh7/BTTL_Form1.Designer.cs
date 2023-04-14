namespace LTGD_BaiThucHanh7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTTL_Form1));
            this.cbDrive = new System.Windows.Forms.ComboBox();
            this.grboxViewMode = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lvDrive = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgLargeList = new System.Windows.Forms.ImageList(this.components);
            this.imgSmallList = new System.Windows.Forms.ImageList(this.components);
            this.lbPath = new System.Windows.Forms.Label();
            this.grboxViewMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDrive
            // 
            this.cbDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrive.FormattingEnabled = true;
            this.cbDrive.Location = new System.Drawing.Point(12, 12);
            this.cbDrive.Name = "cbDrive";
            this.cbDrive.Size = new System.Drawing.Size(325, 46);
            this.cbDrive.TabIndex = 0;
            this.cbDrive.SelectedIndexChanged += new System.EventHandler(this.CbDrive_SelectedIndexChanged);
            // 
            // grboxViewMode
            // 
            this.grboxViewMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grboxViewMode.Controls.Add(this.radioButton5);
            this.grboxViewMode.Controls.Add(this.radioButton4);
            this.grboxViewMode.Controls.Add(this.radioButton3);
            this.grboxViewMode.Controls.Add(this.radioButton2);
            this.grboxViewMode.Controls.Add(this.radioButton1);
            this.grboxViewMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxViewMode.Location = new System.Drawing.Point(1055, 64);
            this.grboxViewMode.Name = "grboxViewMode";
            this.grboxViewMode.Size = new System.Drawing.Size(210, 613);
            this.grboxViewMode.TabIndex = 1;
            this.grboxViewMode.TabStop = false;
            this.grboxViewMode.Text = "View Mode";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(32, 454);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(76, 33);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Tile";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(32, 372);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(108, 33);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Details";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(32, 290);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 33);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "List";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 208);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 33);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SmallIcon";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 33);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "LargeIcon";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // lvDrive
            // 
            this.lvDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDrive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDrive.HideSelection = false;
            this.lvDrive.LargeImageList = this.imgLargeList;
            this.lvDrive.Location = new System.Drawing.Point(12, 64);
            this.lvDrive.MultiSelect = false;
            this.lvDrive.Name = "lvDrive";
            this.lvDrive.Size = new System.Drawing.Size(1037, 613);
            this.lvDrive.SmallImageList = this.imgSmallList;
            this.lvDrive.TabIndex = 2;
            this.lvDrive.UseCompatibleStateImageBehavior = false;
            this.lvDrive.View = System.Windows.Forms.View.Details;
            this.lvDrive.SelectedIndexChanged += new System.EventHandler(this.LvDrive_SelectedIndexChanged);
            this.lvDrive.DoubleClick += new System.EventHandler(this.LvDrive_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File name";
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 211;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last accessed";
            this.columnHeader3.Width = 398;
            // 
            // imgLargeList
            // 
            this.imgLargeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLargeList.ImageStream")));
            this.imgLargeList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLargeList.Images.SetKeyName(0, "folder.ico");
            this.imgLargeList.Images.SetKeyName(1, "documents.ico");
            // 
            // imgSmallList
            // 
            this.imgSmallList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSmallList.ImageStream")));
            this.imgSmallList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSmallList.Images.SetKeyName(0, "folder.ico");
            this.imgSmallList.Images.SetKeyName(1, "documents.ico");
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.Location = new System.Drawing.Point(365, 21);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(66, 29);
            this.lbPath.TabIndex = 3;
            this.lbPath.Text = "label";
            // 
            // BTTL_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 689);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lvDrive);
            this.Controls.Add(this.grboxViewMode);
            this.Controls.Add(this.cbDrive);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "BTTL_Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTTL_Form1";
            this.Load += new System.EventHandler(this.BTTL_Form1_Load);
            this.grboxViewMode.ResumeLayout(false);
            this.grboxViewMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDrive;
        private System.Windows.Forms.GroupBox grboxViewMode;
        private System.Windows.Forms.ListView lvDrive;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ImageList imgLargeList;
        private System.Windows.Forms.ImageList imgSmallList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}