namespace Game_Loto
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Host = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.PlayerInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Host
            // 
            this.Host.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Host.BackColor = System.Drawing.SystemColors.Control;
            this.Host.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Host.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Host.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Host.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Host.Location = new System.Drawing.Point(430, 362);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(191, 53);
            this.Host.TabIndex = 0;
            this.Host.Text = "Người kêu";
            this.Host.UseVisualStyleBackColor = false;
            this.Host.Click += new System.EventHandler(this.Host_Click);
            // 
            // Player
            // 
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.BackColor = System.Drawing.SystemColors.Control;
            this.Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Player.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Player.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Player.Location = new System.Drawing.Point(430, 446);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(191, 53);
            this.Player.TabIndex = 0;
            this.Player.Text = "Người chơi";
            this.Player.UseVisualStyleBackColor = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Exit.Location = new System.Drawing.Point(430, 530);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(191, 53);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PlayerInfo
            // 
            this.PlayerInfo.BackColor = System.Drawing.Color.Firebrick;
            this.PlayerInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayerInfo.BackgroundImage")));
            this.PlayerInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.PlayerInfo.Location = new System.Drawing.Point(12, 12);
            this.PlayerInfo.Name = "PlayerInfo";
            this.PlayerInfo.Size = new System.Drawing.Size(50, 50);
            this.PlayerInfo.TabIndex = 1;
            this.PlayerInfo.UseVisualStyleBackColor = false;
            this.PlayerInfo.Click += new System.EventHandler(this.PlayerInfo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.PlayerInfo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Host);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Host;
        private Button Player;
        private Button Exit;
        private Button PlayerInfo;
    }
}