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
using FireSharp.Config;
using FireSharp.Interfaces;

namespace vbEngC
{
    public partial class Form4 : Form
    {
        bool On;
        Point Pos;
        public Form4()
        {
            InitializeComponent();
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            adminpanel.Controls.Clear();
            adminpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void list_Click(object sender, EventArgs e)
        {

            Admin uc = new Admin();
           addUserControl(uc);
        }

        private void wait_Click(object sender, EventArgs e)
        {
            AdminWait uc = new AdminWait();
            addUserControl(uc);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            //AdminEdit uc = new Admin();
            //addUserControl(uc);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            //AdminSub uc = new Admin();
            //addUserControl(uc);
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


    }
}
