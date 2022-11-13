namespace vbEngC
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.MENU = new System.Windows.Forms.Panel();
            this.Menu5 = new System.Windows.Forms.Button();
            this.Menu4 = new System.Windows.Forms.Button();
            this.Menu3 = new System.Windows.Forms.Button();
            this.Menu2 = new System.Windows.Forms.Button();
            this.Menu1 = new System.Windows.Forms.Button();
            this.dash_label = new System.Windows.Forms.Label();
            this.subc_label = new System.Windows.Forms.Label();
            this.mod_label = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.server_label = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.Dash2 = new System.Windows.Forms.SplitContainer();
            this.Dash1 = new System.Windows.Forms.SplitContainer();
            this.MENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dash2)).BeginInit();
            this.Dash2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dash1)).BeginInit();
            this.Dash1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MENU.Controls.Add(this.Menu5);
            this.MENU.Controls.Add(this.Menu4);
            this.MENU.Controls.Add(this.Menu3);
            this.MENU.Controls.Add(this.Menu2);
            this.MENU.Controls.Add(this.Menu1);
            this.MENU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.MENU.Location = new System.Drawing.Point(-8, -8);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(169, 636);
            this.MENU.TabIndex = 0;
            // 
            // Menu5
            // 
            this.Menu5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu5.FlatAppearance.BorderSize = 0;
            this.Menu5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu5.ForeColor = System.Drawing.Color.White;
            this.Menu5.Image = ((System.Drawing.Image)(resources.GetObject("Menu5.Image")));
            this.Menu5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Menu5.Location = new System.Drawing.Point(-4, 482);
            this.Menu5.Name = "Menu5";
            this.Menu5.Size = new System.Drawing.Size(184, 94);
            this.Menu5.TabIndex = 6;
            this.Menu5.Text = "구독하기";
            this.Menu5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Menu5.UseVisualStyleBackColor = true;
            this.Menu5.Click += new System.EventHandler(this.Menu5_Click);
            // 
            // Menu4
            // 
            this.Menu4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu4.FlatAppearance.BorderSize = 0;
            this.Menu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu4.ForeColor = System.Drawing.Color.White;
            this.Menu4.Image = ((System.Drawing.Image)(resources.GetObject("Menu4.Image")));
            this.Menu4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Menu4.Location = new System.Drawing.Point(-4, 379);
            this.Menu4.Name = "Menu4";
            this.Menu4.Size = new System.Drawing.Size(184, 94);
            this.Menu4.TabIndex = 5;
            this.Menu4.Text = "오류 해결";
            this.Menu4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Menu4.UseVisualStyleBackColor = true;
            this.Menu4.Click += new System.EventHandler(this.Menu4_Click);
            // 
            // Menu3
            // 
            this.Menu3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu3.FlatAppearance.BorderSize = 0;
            this.Menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu3.ForeColor = System.Drawing.Color.White;
            this.Menu3.Image = ((System.Drawing.Image)(resources.GetObject("Menu3.Image")));
            this.Menu3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Menu3.Location = new System.Drawing.Point(-4, 277);
            this.Menu3.Name = "Menu3";
            this.Menu3.Size = new System.Drawing.Size(184, 94);
            this.Menu3.TabIndex = 4;
            this.Menu3.Text = "모드 관리";
            this.Menu3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Menu3.UseVisualStyleBackColor = true;
            this.Menu3.Click += new System.EventHandler(this.Menu3_Click);
            // 
            // Menu2
            // 
            this.Menu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu2.FlatAppearance.BorderSize = 0;
            this.Menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu2.ForeColor = System.Drawing.Color.White;
            this.Menu2.Image = ((System.Drawing.Image)(resources.GetObject("Menu2.Image")));
            this.Menu2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Menu2.Location = new System.Drawing.Point(-4, 165);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(184, 94);
            this.Menu2.TabIndex = 3;
            this.Menu2.Text = "서버 관리";
            this.Menu2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Menu2.UseVisualStyleBackColor = true;
            this.Menu2.Click += new System.EventHandler(this.Menu2_Click);
            // 
            // Menu1
            // 
            this.Menu1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Menu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu1.FlatAppearance.BorderSize = 0;
            this.Menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu1.ForeColor = System.Drawing.Color.White;
            this.Menu1.Image = ((System.Drawing.Image)(resources.GetObject("Menu1.Image")));
            this.Menu1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Menu1.Location = new System.Drawing.Point(-4, 54);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(184, 95);
            this.Menu1.TabIndex = 2;
            this.Menu1.Text = "대시보드";
            this.Menu1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Menu1.UseVisualStyleBackColor = true;
            this.Menu1.Click += new System.EventHandler(this.Menu1_Click);
            // 
            // dash_label
            // 
            this.dash_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.dash_label.Image = ((System.Drawing.Image)(resources.GetObject("dash_label.Image")));
            this.dash_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_label.Location = new System.Drawing.Point(184, 6);
            this.dash_label.Name = "dash_label";
            this.dash_label.Size = new System.Drawing.Size(112, 30);
            this.dash_label.TabIndex = 6;
            this.dash_label.Text = "대시보드";
            this.dash_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subc_label
            // 
            this.subc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.subc_label.Image = ((System.Drawing.Image)(resources.GetObject("subc_label.Image")));
            this.subc_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subc_label.Location = new System.Drawing.Point(184, 5);
            this.subc_label.Name = "subc_label";
            this.subc_label.Size = new System.Drawing.Size(112, 30);
            this.subc_label.TabIndex = 11;
            this.subc_label.Text = "구독하기";
            this.subc_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subc_label.Visible = false;
            // 
            // mod_label
            // 
            this.mod_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.mod_label.Image = ((System.Drawing.Image)(resources.GetObject("mod_label.Image")));
            this.mod_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mod_label.Location = new System.Drawing.Point(184, 5);
            this.mod_label.Name = "mod_label";
            this.mod_label.Size = new System.Drawing.Size(112, 30);
            this.mod_label.TabIndex = 9;
            this.mod_label.Text = "모드 관리";
            this.mod_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mod_label.Visible = false;
            // 
            // error_label
            // 
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.error_label.Image = ((System.Drawing.Image)(resources.GetObject("error_label.Image")));
            this.error_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.error_label.Location = new System.Drawing.Point(184, 5);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(112, 30);
            this.error_label.TabIndex = 10;
            this.error_label.Text = "오류 해결";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error_label.Visible = false;
            // 
            // server_label
            // 
            this.server_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.server_label.Image = ((System.Drawing.Image)(resources.GetObject("server_label.Image")));
            this.server_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.server_label.Location = new System.Drawing.Point(184, 5);
            this.server_label.Name = "server_label";
            this.server_label.Size = new System.Drawing.Size(112, 30);
            this.server_label.TabIndex = 8;
            this.server_label.Text = "서버 관리";
            this.server_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.server_label.Visible = false;
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(824, 5);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 30);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "로그아웃";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Profile
            // 
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.FlatAppearance.BorderSize = 0;
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.Profile.Location = new System.Drawing.Point(743, 5);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(75, 29);
            this.Profile.TabIndex = 5;
            this.Profile.Text = "프로필";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // Dash2
            // 
            this.Dash2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dash2.Location = new System.Drawing.Point(167, 327);
            this.Dash2.Name = "Dash2";
            this.Dash2.Size = new System.Drawing.Size(743, 274);
            this.Dash2.SplitterDistance = 373;
            this.Dash2.TabIndex = 3;
            // 
            // Dash1
            // 
            this.Dash1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dash1.Location = new System.Drawing.Point(167, 47);
            this.Dash1.Name = "Dash1";
            // 
            // Dash1.Panel1
            // 
            this.Dash1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Dash1_Panel1_Paint);
            this.Dash1.Size = new System.Drawing.Size(743, 274);
            this.Dash1.SplitterDistance = 373;
            this.Dash1.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(914, 625);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.Dash2);
            this.Controls.Add(this.Dash1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.server_label);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.mod_label);
            this.Controls.Add(this.dash_label);
            this.Controls.Add(this.subc_label);
            this.Controls.Add(this.error_label);
            this.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MENU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dash2)).EndInit();
            this.Dash2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dash1)).EndInit();
            this.Dash1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MENU;
        private System.Windows.Forms.Button Menu1;
        private System.Windows.Forms.Button Menu2;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label dash_label;
        private System.Windows.Forms.Button Menu3;
        private System.Windows.Forms.Button Menu5;
        private System.Windows.Forms.Button Menu4;
        private System.Windows.Forms.Label server_label;
        private System.Windows.Forms.Label subc_label;
        private System.Windows.Forms.Label mod_label;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.SplitContainer Dash2;
        public System.Windows.Forms.SplitContainer Dash1;
    }
}