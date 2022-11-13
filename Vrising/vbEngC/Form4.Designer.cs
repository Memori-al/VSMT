namespace vbEngC
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.adminpanel = new System.Windows.Forms.Panel();
            this.adminmenu = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.wait = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.adminmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminpanel
            // 
            this.adminpanel.AutoScroll = true;
            this.adminpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.adminpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.adminpanel.Location = new System.Drawing.Point(102, 0);
            this.adminpanel.Name = "adminpanel";
            this.adminpanel.Size = new System.Drawing.Size(476, 319);
            this.adminpanel.TabIndex = 3;
            // 
            // adminmenu
            // 
            this.adminmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.adminmenu.Controls.Add(this.back);
            this.adminmenu.Controls.Add(this.sub);
            this.adminmenu.Controls.Add(this.wait);
            this.adminmenu.Controls.Add(this.list);
            this.adminmenu.Location = new System.Drawing.Point(0, 78);
            this.adminmenu.Name = "adminmenu";
            this.adminmenu.Size = new System.Drawing.Size(99, 241);
            this.adminmenu.TabIndex = 2;
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(3, 200);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(93, 37);
            this.back.TabIndex = 5;
            this.back.Text = "돌아가기";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // sub
            // 
            this.sub.FlatAppearance.BorderSize = 0;
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            this.sub.ForeColor = System.Drawing.Color.White;
            this.sub.Image = ((System.Drawing.Image)(resources.GetObject("sub.Image")));
            this.sub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sub.Location = new System.Drawing.Point(3, 95);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(93, 37);
            this.sub.TabIndex = 3;
            this.sub.Text = "구독관리";
            this.sub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.edit_Click);
            // 
            // wait
            // 
            this.wait.FlatAppearance.BorderSize = 0;
            this.wait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wait.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            this.wait.ForeColor = System.Drawing.Color.White;
            this.wait.Image = ((System.Drawing.Image)(resources.GetObject("wait.Image")));
            this.wait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wait.Location = new System.Drawing.Point(3, 48);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(93, 37);
            this.wait.TabIndex = 2;
            this.wait.Text = "발급대기";
            this.wait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wait.UseVisualStyleBackColor = true;
            this.wait.Click += new System.EventHandler(this.wait_Click);
            // 
            // list
            // 
            this.list.FlatAppearance.BorderSize = 0;
            this.list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold);
            this.list.ForeColor = System.Drawing.Color.White;
            this.list.Image = ((System.Drawing.Image)(resources.GetObject("list.Image")));
            this.list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.list.Location = new System.Drawing.Point(3, 4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(93, 37);
            this.list.TabIndex = 1;
            this.list.Text = "회원관리";
            this.list.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(578, 319);
            this.Controls.Add(this.adminmenu);
            this.Controls.Add(this.adminpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.adminmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminpanel;
        private System.Windows.Forms.Panel adminmenu;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button wait;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Button back;
    }
}