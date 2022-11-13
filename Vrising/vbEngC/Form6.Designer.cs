namespace vbEngC
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.ipv4 = new System.Windows.Forms.TextBox();
            this.connection = new System.Windows.Forms.Button();
            this.tcpinfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.disconnetion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.serinfo = new System.Windows.Forms.Button();
            this.verify = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reboot = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.export = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.castle_damage = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.server_mode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.databk = new System.Windows.Forms.Button();
            this.serverstart = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.import = new System.Windows.Forms.Button();
            this.minimum = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ipv4
            // 
            this.ipv4.Location = new System.Drawing.Point(12, 14);
            this.ipv4.Name = "ipv4";
            this.ipv4.Size = new System.Drawing.Size(190, 21);
            this.ipv4.TabIndex = 0;
            this.ipv4.Text = "서버 주소를 입력하세요.";
            this.ipv4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connection
            // 
            this.connection.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connection.ForeColor = System.Drawing.Color.White;
            this.connection.Location = new System.Drawing.Point(208, 14);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(45, 21);
            this.connection.TabIndex = 1;
            this.connection.Text = "연결";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // tcpinfo
            // 
            this.tcpinfo.FlatAppearance.BorderSize = 0;
            this.tcpinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcpinfo.ForeColor = System.Drawing.Color.White;
            this.tcpinfo.Location = new System.Drawing.Point(12, 40);
            this.tcpinfo.Name = "tcpinfo";
            this.tcpinfo.Size = new System.Drawing.Size(190, 21);
            this.tcpinfo.TabIndex = 2;
            this.tcpinfo.Text = "Ipv4 주소를 입력해주세요.";
            this.tcpinfo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.disconnetion);
            this.panel1.Controls.Add(this.ipv4);
            this.panel1.Controls.Add(this.tcpinfo);
            this.panel1.Controls.Add(this.connection);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 71);
            this.panel1.TabIndex = 3;
            // 
            // disconnetion
            // 
            this.disconnetion.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.disconnetion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnetion.ForeColor = System.Drawing.Color.White;
            this.disconnetion.Location = new System.Drawing.Point(208, 41);
            this.disconnetion.Name = "disconnetion";
            this.disconnetion.Size = new System.Drawing.Size(45, 21);
            this.disconnetion.TabIndex = 3;
            this.disconnetion.Text = "끊기";
            this.disconnetion.UseVisualStyleBackColor = true;
            this.disconnetion.Click += new System.EventHandler(this.disconnetion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.serinfo);
            this.panel2.Location = new System.Drawing.Point(292, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 71);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "서버 연결 현황";
            // 
            // serinfo
            // 
            this.serinfo.FlatAppearance.BorderSize = 0;
            this.serinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serinfo.ForeColor = System.Drawing.Color.White;
            this.serinfo.Location = new System.Drawing.Point(10, 24);
            this.serinfo.Name = "serinfo";
            this.serinfo.Size = new System.Drawing.Size(171, 34);
            this.serinfo.TabIndex = 2;
            this.serinfo.UseVisualStyleBackColor = true;
            // 
            // verify
            // 
            this.verify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verify.ForeColor = System.Drawing.Color.White;
            this.verify.Image = ((System.Drawing.Image)(resources.GetObject("verify.Image")));
            this.verify.Location = new System.Drawing.Point(13, 34);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(114, 136);
            this.verify.TabIndex = 7;
            this.verify.TabStop = false;
            this.verify.Text = "무결성 검사";
            this.verify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.reboot);
            this.panel3.Controls.Add(this.verify);
            this.panel3.Location = new System.Drawing.Point(12, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 202);
            this.panel3.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 21);
            this.button5.TabIndex = 4;
            this.button5.Text = "[검사 결과 방화벽 및 포트 개방 확인됨]";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "호스팅 서버 패널";
            // 
            // reboot
            // 
            this.reboot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reboot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reboot.ForeColor = System.Drawing.Color.White;
            this.reboot.Image = ((System.Drawing.Image)(resources.GetObject("reboot.Image")));
            this.reboot.Location = new System.Drawing.Point(139, 34);
            this.reboot.Name = "reboot";
            this.reboot.Size = new System.Drawing.Size(114, 136);
            this.reboot.TabIndex = 8;
            this.reboot.TabStop = false;
            this.reboot.Text = "리부팅 명령";
            this.reboot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reboot.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(292, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 202);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "호스팅 서버 정보";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // export
            // 
            this.export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export.ForeColor = System.Drawing.Color.White;
            this.export.Location = new System.Drawing.Point(846, 475);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(93, 26);
            this.export.TabIndex = 9;
            this.export.Text = "저장하기";
            this.export.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(370, 433);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(376, 416);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "클랜 제한 인원";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(44, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "마늘 영향 배율";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(29, 125);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 20);
            this.comboBox6.TabIndex = 24;
            this.comboBox6.Text = "선택 혹은 입력";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(314, 298);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(320, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "클랜 제한 인원";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(311, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "공성 무기 체력";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(296, 79);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 20);
            this.comboBox5.TabIndex = 20;
            this.comboBox5.Text = "선택";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(314, 246);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(320, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "클랜 제한 인원";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(320, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "클랜 제한 인원";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(296, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "사망한 플레이어 약탈";
            // 
            // castle_damage
            // 
            this.castle_damage.FormattingEnabled = true;
            this.castle_damage.Location = new System.Drawing.Point(296, 33);
            this.castle_damage.Name = "castle_damage";
            this.castle_damage.Size = new System.Drawing.Size(121, 20);
            this.castle_damage.TabIndex = 13;
            this.castle_damage.Text = "선택";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(175, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "영혼 조각 수량";
            // 
            // server_mode
            // 
            this.server_mode.FormattingEnabled = true;
            this.server_mode.Location = new System.Drawing.Point(163, 79);
            this.server_mode.Name = "server_mode";
            this.server_mode.Size = new System.Drawing.Size(121, 20);
            this.server_mode.TabIndex = 11;
            this.server_mode.Text = "선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(669, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "게임 서버 설정";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(488, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "서버 설정 적용 전 게임 서버를 종료해주세요.\r\n이전 서버 설정은 자동으로 백업됩니다.";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.comboBox7);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.comboBox2);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.textBox6);
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.comboBox6);
            this.panel6.Controls.Add(this.comboBox3);
            this.panel6.Controls.Add(this.textBox5);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.comboBox4);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.comboBox5);
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.server_mode);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.castle_damage);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(488, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(449, 455);
            this.panel6.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(44, 158);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 12);
            this.label22.TabIndex = 33;
            this.label22.Text = "피의 결속 장비";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(29, 175);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 20);
            this.comboBox7.TabIndex = 32;
            this.comboBox7.Text = "선택";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(312, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 12);
            this.label20.TabIndex = 31;
            this.label20.Text = "햇빛 영향 배율";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(297, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.Text = "선택 혹은 입력";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(181, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 12);
            this.label19.TabIndex = 29;
            this.label19.Text = "은 영향 배율";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Text = "선택 혹은 입력";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 21);
            this.textBox3.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(175, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "클랜 제한 인원";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(41, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "성채 데미지 모드";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(29, 79);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.Text = "선택";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(56, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "서버 모드";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "PvE",
            "PvP"});
            this.comboBox4.Location = new System.Drawing.Point(29, 32);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 18;
            this.comboBox4.Text = "선택";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.databk);
            this.panel5.Controls.Add(this.serverstart);
            this.panel5.Location = new System.Drawing.Point(12, 327);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 202);
            this.panel5.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(12, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(241, 21);
            this.button6.TabIndex = 4;
            this.button6.Text = "클라이언트에 데이터가 저장되었습니다.";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(87, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "게임 관리 패널";
            // 
            // databk
            // 
            this.databk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.databk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.databk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databk.ForeColor = System.Drawing.Color.White;
            this.databk.Image = ((System.Drawing.Image)(resources.GetObject("databk.Image")));
            this.databk.Location = new System.Drawing.Point(139, 34);
            this.databk.Name = "databk";
            this.databk.Size = new System.Drawing.Size(114, 136);
            this.databk.TabIndex = 8;
            this.databk.TabStop = false;
            this.databk.Text = "데이터 백업";
            this.databk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.databk.UseVisualStyleBackColor = true;
            // 
            // serverstart
            // 
            this.serverstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverstart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.serverstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverstart.ForeColor = System.Drawing.Color.White;
            this.serverstart.Image = ((System.Drawing.Image)(resources.GetObject("serverstart.Image")));
            this.serverstart.Location = new System.Drawing.Point(13, 34);
            this.serverstart.Name = "serverstart";
            this.serverstart.Size = new System.Drawing.Size(114, 136);
            this.serverstart.TabIndex = 7;
            this.serverstart.TabStop = false;
            this.serverstart.Text = "서버 구동/종료";
            this.serverstart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.serverstart.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel7.Controls.Add(this.label18);
            this.panel7.Location = new System.Drawing.Point(292, 327);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(184, 202);
            this.panel7.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(50, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "게임 서버 정보";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel8.Controls.Add(this.import);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.export);
            this.panel8.Location = new System.Drawing.Point(-2, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(951, 512);
            this.panel8.TabIndex = 10;
            // 
            // import
            // 
            this.import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import.ForeColor = System.Drawing.Color.White;
            this.import.Location = new System.Drawing.Point(747, 475);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(93, 26);
            this.import.TabIndex = 11;
            this.import.Text = "불러오기";
            this.import.UseVisualStyleBackColor = true;
            // 
            // minimum
            // 
            this.minimum.FlatAppearance.BorderSize = 0;
            this.minimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimum.ForeColor = System.Drawing.Color.White;
            this.minimum.Location = new System.Drawing.Point(896, 3);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(22, 23);
            this.minimum.TabIndex = 11;
            this.minimum.Text = "─";
            this.minimum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimum.UseVisualStyleBackColor = true;
            this.minimum.Click += new System.EventHandler(this.minimum_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(925, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 23);
            this.close.TabIndex = 33;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(43, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 12);
            this.label21.TabIndex = 4;
            this.label21.Text = "서버 관리 도구 :: VSMT";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(948, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimum);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipv4;
        private System.Windows.Forms.Button connection;
        private System.Windows.Forms.Button tcpinfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button serinfo;
        private System.Windows.Forms.Button verify;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button reboot;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox castle_damage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox server_mode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button databk;
        private System.Windows.Forms.Button serverstart;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button disconnetion;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button minimum;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox7;
    }
}