namespace Game_Loto
{
    partial class Host
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Host));
            this.Random = new System.Windows.Forms.Button();
            this.pnRandom = new System.Windows.Forms.FlowLayoutPanel();
            this.lbId = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Random
            // 
            this.Random.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Random.Location = new System.Drawing.Point(437, 252);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(178, 47);
            this.Random.TabIndex = 0;
            this.Random.Text = "Bốc số";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // pnRandom
            // 
            this.pnRandom.Location = new System.Drawing.Point(12, 305);
            this.pnRandom.Name = "pnRandom";
            this.pnRandom.Size = new System.Drawing.Size(1040, 364);
            this.pnRandom.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbId.Location = new System.Drawing.Point(0, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(106, 25);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID Phòng: ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(112, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(23, 25);
            this.ID.TabIndex = 2;
            this.ID.Text = "0";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.pnRandom);
            this.Controls.Add(this.Random);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Host";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người kêu";
            this.Load += new System.EventHandler(this.Host_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Random;
        private FlowLayoutPanel pnRandom;
        private Label lbId;
        private Label ID;
        private System.Windows.Forms.Timer Timer;
    }
}