namespace Game_Loto
{
    partial class PlayerInfor_Show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerInfor_Show));
            this.lbName = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbWin = new System.Windows.Forms.Label();
            this.avata = new System.Windows.Forms.PictureBox();
            this.btnAvt = new System.Windows.Forms.Button();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avata)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbName.Location = new System.Drawing.Point(25, 284);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(149, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên người chơi:";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMoney.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbMoney.Location = new System.Drawing.Point(25, 327);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(94, 25);
            this.lbMoney.TabIndex = 0;
            this.lbMoney.Text = "Tài chính:";
            this.lbMoney.Click += new System.EventHandler(this.lbMoney_Click);
            // 
            // lbWin
            // 
            this.lbWin.AutoSize = true;
            this.lbWin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWin.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbWin.Location = new System.Drawing.Point(25, 370);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(139, 25);
            this.lbWin.TabIndex = 0;
            this.lbWin.Text = "Số trận thắng:";
            this.lbWin.Click += new System.EventHandler(this.lbWin_Click);
            // 
            // avata
            // 
            this.avata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avata.Image = ((System.Drawing.Image)(resources.GetObject("avata.Image")));
            this.avata.Location = new System.Drawing.Point(197, 26);
            this.avata.Name = "avata";
            this.avata.Size = new System.Drawing.Size(190, 190);
            this.avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avata.TabIndex = 1;
            this.avata.TabStop = false;
            // 
            // btnAvt
            // 
            this.btnAvt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAvt.BackgroundImage")));
            this.btnAvt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvt.Location = new System.Drawing.Point(274, 222);
            this.btnAvt.Name = "btnAvt";
            this.btnAvt.Size = new System.Drawing.Size(36, 36);
            this.btnAvt.TabIndex = 2;
            this.btnAvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvt.UseVisualStyleBackColor = true;
            this.btnAvt.Click += new System.EventHandler(this.btnAvt_Click);
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.White;
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoney.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoney.Location = new System.Drawing.Point(199, 326);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(182, 26);
            this.txtMoney.TabIndex = 3;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNum.Location = new System.Drawing.Point(200, 368);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(182, 26);
            this.txtNum.TabIndex = 3;
            this.txtNum.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.Location = new System.Drawing.Point(187, 561);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu và thoát";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(200, 284);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 26);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ip.Location = new System.Drawing.Point(86, 26);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(0, 25);
            this.ip.TabIndex = 6;
            // 
            // PlayerInfor_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.btnAvt);
            this.Controls.Add(this.avata);
            this.Controls.Add(this.lbWin);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayerInfor_Show";
            this.Opacity = 0D;
            this.Text = "Thông tin người chơi";
            this.Load += new System.EventHandler(this.PlayerInfor_Show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbName;
        private Label lbMoney;
        private Label lbWin;
        private PictureBox avata;
        private Button btnAvt;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private TextBox txtMoney;
        private TextBox txtNum;
        private Button btnSave;
        private TextBox txtName;
        private Label ip;
    }
}