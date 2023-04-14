namespace LTGD_BaiThucHanh5
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
            this.flowPnlBound = new System.Windows.Forms.FlowLayoutPanel();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowPnlBound
            // 
            this.flowPnlBound.AutoScroll = true;
            this.flowPnlBound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowPnlBound.Location = new System.Drawing.Point(710, 11);
            this.flowPnlBound.Name = "flowPnlBound";
            this.flowPnlBound.Size = new System.Drawing.Size(120, 400);
            this.flowPnlBound.TabIndex = 0;
            this.flowPnlBound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlowPnlBound_MouseDown);
            this.flowPnlBound.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FlowPnlBound_MouseMove);
            // 
            // labelText
            // 
            this.labelText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.Blue;
            this.labelText.Location = new System.Drawing.Point(12, 414);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(818, 61);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "label1";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 484);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.flowPnlBound);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPnlBound;
        private System.Windows.Forms.Label labelText;
    }
}

