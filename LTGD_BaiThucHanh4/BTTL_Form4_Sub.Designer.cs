namespace LTGD_BaiThucHanh4
{
    partial class BTTL_Form4_Sub
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLoad,
            this.tsmOpen,
            this.tsmClear,
            this.tsmSave,
            this.tsmClose});
            this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmLoad
            // 
            this.tsmLoad.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmLoad.MergeIndex = 1;
            this.tsmLoad.Name = "tsmLoad";
            this.tsmLoad.Size = new System.Drawing.Size(224, 26);
            this.tsmLoad.Text = "Load";
            this.tsmLoad.Click += new System.EventHandler(this.TsmLoad_Click);
            // 
            // tsmOpen
            // 
            this.tsmOpen.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmOpen.MergeIndex = 2;
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(224, 26);
            this.tsmOpen.Text = "Open";
            this.tsmOpen.Click += new System.EventHandler(this.TsmOpen_Click);
            // 
            // tsmClear
            // 
            this.tsmClear.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmClear.MergeIndex = 3;
            this.tsmClear.Name = "tsmClear";
            this.tsmClear.Size = new System.Drawing.Size(224, 26);
            this.tsmClear.Text = "Clear";
            this.tsmClear.Click += new System.EventHandler(this.TsmClear_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmSave.MergeIndex = 4;
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(224, 26);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.TsmSave_Click);
            // 
            // tsmClose
            // 
            this.tsmClose.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmClose.MergeIndex = 6;
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(224, 26);
            this.tsmClose.Text = "Close";
            this.tsmClose.Click += new System.EventHandler(this.TsmClose_Click);
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(880, 469);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // BTTL_Form4_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 469);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "BTTL_Form4_Sub";
            this.Text = "Form8_MDISub";
            this.Load += new System.EventHandler(this.Form8_MDISub_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmClear;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.PictureBox picImage;
    }
}