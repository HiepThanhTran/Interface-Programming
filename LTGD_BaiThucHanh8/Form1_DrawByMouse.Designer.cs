namespace LTGD_BaiThucHanh8
{
    partial class Form1_DrawByMouse
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
            this.SuspendLayout();
            // 
            // Form1_DrawByMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1_DrawByMouse";
            this.Text = "Draw By Mouse";
            this.Load += new System.EventHandler(this.Form1_DrawByMouse_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_DrawByMouse_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_DrawByMouse_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_DrawByMouse_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}