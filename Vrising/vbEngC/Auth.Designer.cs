namespace vbEngC
{
    partial class Auth
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.closebtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pwconbox = new System.Windows.Forms.TextBox();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Authcon = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AutoLogin = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.issue = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Authcon)).BeginInit();
            this.Authcon.Panel1.SuspendLayout();
            this.Authcon.Panel2.SuspendLayout();
            this.Authcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.closebtn.Location = new System.Drawing.Point(260, 7);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(27, 30);
            this.closebtn.TabIndex = 29;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(17, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "계정 발급까지 최대 1일이 소요될 수 있습니다.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("A Pompadour Sample", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(83, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 31);
            this.label5.TabIndex = 27;
            this.label5.Text = "계정 발급";
            // 
            // pwconbox
            // 
            this.pwconbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pwconbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwconbox.Location = new System.Drawing.Point(44, 272);
            this.pwconbox.Name = "pwconbox";
            this.pwconbox.Size = new System.Drawing.Size(187, 26);
            this.pwconbox.TabIndex = 26;
            // 
            // pwbox
            // 
            this.pwbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pwbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwbox.Location = new System.Drawing.Point(44, 211);
            this.pwbox.Name = "pwbox";
            this.pwbox.Size = new System.Drawing.Size(187, 26);
            this.pwbox.TabIndex = 25;
            // 
            // idbox
            // 
            this.idbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbox.Location = new System.Drawing.Point(44, 153);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(187, 26);
            this.idbox.TabIndex = 24;
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.Location = new System.Drawing.Point(44, 96);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(187, 26);
            this.namebox.TabIndex = 23;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(44, 318);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(187, 32);
            this.register.TabIndex = 22;
            this.register.Text = "회원가입";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(40, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "비밀번호 확인";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(40, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(40, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(40, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "이름";
            // 
            // Authcon
            // 
            this.Authcon.Location = new System.Drawing.Point(3, 3);
            this.Authcon.Name = "Authcon";
            // 
            // Authcon.Panel1
            // 
            this.Authcon.Panel1.Controls.Add(this.closebtn);
            this.Authcon.Panel1.Controls.Add(this.pwconbox);
            this.Authcon.Panel1.Controls.Add(this.label6);
            this.Authcon.Panel1.Controls.Add(this.label1);
            this.Authcon.Panel1.Controls.Add(this.label5);
            this.Authcon.Panel1.Controls.Add(this.label2);
            this.Authcon.Panel1.Controls.Add(this.label3);
            this.Authcon.Panel1.Controls.Add(this.pwbox);
            this.Authcon.Panel1.Controls.Add(this.label4);
            this.Authcon.Panel1.Controls.Add(this.idbox);
            this.Authcon.Panel1.Controls.Add(this.register);
            this.Authcon.Panel1.Controls.Add(this.namebox);
            // 
            // Authcon.Panel2
            // 
            this.Authcon.Panel2.Controls.Add(this.label7);
            this.Authcon.Panel2.Controls.Add(this.label8);
            this.Authcon.Panel2.Controls.Add(this.AutoLogin);
            this.Authcon.Panel2.Controls.Add(this.label9);
            this.Authcon.Panel2.Controls.Add(this.ID);
            this.Authcon.Panel2.Controls.Add(this.PW);
            this.Authcon.Panel2.Controls.Add(this.pictureBox2);
            this.Authcon.Panel2.Controls.Add(this.label10);
            this.Authcon.Panel2.Controls.Add(this.button1);
            this.Authcon.Panel2.Controls.Add(this.label11);
            this.Authcon.Panel2.Controls.Add(this.issue);
            this.Authcon.Panel2.Controls.Add(this.Login);
            this.Authcon.Panel2.Controls.Add(this.label13);
            this.Authcon.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.Authcon.Size = new System.Drawing.Size(594, 369);
            this.Authcon.SplitterDistance = 294;
            this.Authcon.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("A Pompadour Sample", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "서버 관리 도구";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(108, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "높여드립니다.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // AutoLogin
            // 
            this.AutoLogin.AutoSize = true;
            this.AutoLogin.Font = new System.Drawing.Font("나눔고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AutoLogin.Location = new System.Drawing.Point(54, 238);
            this.AutoLogin.Name = "AutoLogin";
            this.AutoLogin.Size = new System.Drawing.Size(102, 17);
            this.AutoLogin.TabIndex = 30;
            this.AutoLogin.Text = "로그인 상태 유지";
            this.AutoLogin.UseVisualStyleBackColor = true;
            this.AutoLogin.CheckedChanged += new System.EventHandler(this.AutoLogin_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(28, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "압도적인 퍼포먼스로 서버 관리의 만족도를 ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(54, 145);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(187, 26);
            this.ID.TabIndex = 18;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // PW
            // 
            this.PW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW.Location = new System.Drawing.Point(54, 206);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(187, 26);
            this.PW.TabIndex = 19;
            this.PW.UseSystemPasswordChar = true;
            this.PW.TextChanged += new System.EventHandler(this.PW_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(134, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 40);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(50, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "계정";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.button1.Location = new System.Drawing.Point(261, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(54, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "비밀번호";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // issue
            // 
            this.issue.AutoSize = true;
            this.issue.BackColor = System.Drawing.Color.Transparent;
            this.issue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issue.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.issue.ForeColor = System.Drawing.Color.DimGray;
            this.issue.Location = new System.Drawing.Point(118, 324);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(53, 12);
            this.issue.TabIndex = 24;
            this.issue.Text = "발급신청";
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(54, 262);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(187, 32);
            this.Login.TabIndex = 22;
            this.Login.Text = "로그인";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.label13.Location = new System.Drawing.Point(63, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "계정을 발급받지 못하셨나요?";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Authcon);
            this.Name = "Auth";
            this.Size = new System.Drawing.Size(600, 375);
            this.Authcon.Panel1.ResumeLayout(false);
            this.Authcon.Panel1.PerformLayout();
            this.Authcon.Panel2.ResumeLayout(false);
            this.Authcon.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Authcon)).EndInit();
            this.Authcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pwconbox;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer Authcon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox AutoLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label issue;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox idbox;
    }
}
