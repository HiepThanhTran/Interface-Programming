namespace Game_Loto
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.winBtn = new System.Windows.Forms.Button();
            this.createPagebtn = new System.Windows.Forms.Button();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.ID_player = new System.Windows.Forms.Label();
            this.asset = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(670, 668);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // winBtn
            // 
            this.winBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.winBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.winBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.winBtn.Location = new System.Drawing.Point(800, 505);
            this.winBtn.Name = "winBtn";
            this.winBtn.Size = new System.Drawing.Size(166, 54);
            this.winBtn.TabIndex = 1;
            this.winBtn.Text = "Kinh";
            this.winBtn.UseVisualStyleBackColor = true;
            this.winBtn.Click += new System.EventHandler(this.winBtn_Click);
            // 
            // createPagebtn
            // 
            this.createPagebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createPagebtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPagebtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.createPagebtn.Location = new System.Drawing.Point(800, 593);
            this.createPagebtn.Name = "createPagebtn";
            this.createPagebtn.Size = new System.Drawing.Size(166, 54);
            this.createPagebtn.TabIndex = 1;
            this.createPagebtn.Text = "Đổi giấy";
            this.createPagebtn.UseVisualStyleBackColor = true;
            this.createPagebtn.Click += new System.EventHandler(this.createPagebtn_Click);
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMoney.Location = new System.Drawing.Point(706, 57);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(54, 25);
            this.lbMoney.TabIndex = 2;
            this.lbMoney.Text = "Vốn:";
            this.lbMoney.Click += new System.EventHandler(this.lbMoney_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbId.Location = new System.Drawing.Point(706, 12);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(101, 25);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID Phòng:";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // ID_player
            // 
            this.ID_player.AutoSize = true;
            this.ID_player.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID_player.Location = new System.Drawing.Point(813, 12);
            this.ID_player.Name = "ID_player";
            this.ID_player.Size = new System.Drawing.Size(0, 25);
            this.ID_player.TabIndex = 2;
            // 
            // asset
            // 
            this.asset.AutoSize = true;
            this.asset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asset.Location = new System.Drawing.Point(766, 57);
            this.asset.Name = "asset";
            this.asset.Size = new System.Drawing.Size(0, 25);
            this.asset.TabIndex = 2;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(706, 96);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(335, 310);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnServer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnServer.Location = new System.Drawing.Point(800, 427);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(166, 57);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "Kiểm tra";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.asset);
            this.Controls.Add(this.ID_player);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.createPagebtn);
            this.Controls.Add(this.winBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giấy chơi";
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button winBtn;
        private Button createPagebtn;
        private Label lbMoney;
        private Label lbId;
        private Label ID_player;
        private Label money;
        private Label asset;
        private System.Windows.Forms.Timer Timer;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnServer;
    }
}