using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ScottPlot.Renderable;
using System.Security.Policy;

namespace vbEngC                        

{
    public partial class Form3 : Form
    {
        bool On;
        Point Pos;

        public Form3()
        {
            InitializeComponent();
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }

      public void loadform(object Form)
        {
            /*if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();*/
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            //mainpanel.Controls.Clear();
            Dash1.Panel2.Controls.Clear();
            Dash1.Panel1.Controls.Add(userControl);
           // mainpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Menu1_Click(object sender, EventArgs e)
        {

            DashBoard1 uc = new DashBoard1();
            Dash1.Panel1.Controls.Add(uc);
            //addUserControl(uc);
            /* Form5 sh = new Form5();
             sh.FormBorderStyle = FormBorderStyle.None;
             mainpanel.Controls.Clear();
             sh.TopLevel = false;
             mainpanel.Controls.Add(sh);
             sh.Show();
             sh.Dock = DockStyle.Fill;

             mainpanel.Visible = true;
            panel2.Visible = true;
             dash_label.Visible = true;
             server_label.Visible = false;
             mod_label.Visible = false;
             error_label.Visible = false;
             subc_label.Visible = false;
             MessageBox.Show("Test");*/

        }

        private void Menu2_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu3_Click(object sender, EventArgs e)
        {

        }

        private void Menu4_Click(object sender, EventArgs e)
        {

        }

        private void Menu5_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }



        private void mainpanel_Paint(object sender, PaintEventArgs a)
        {

        }

        private void Dash1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
