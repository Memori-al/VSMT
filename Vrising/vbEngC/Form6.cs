using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace vbEngC
{
    public partial class Form6 : Form
    {
        bool On;
        Point Pos;
        public Form6()
        {
            InitializeComponent();
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        public string msg;
        private void connection_Click(object sender, EventArgs e)
        {
            if (ipv4.Text != "서버 주소를 입력하세요.")
            {
                tcpinfo.Text = ipv4.Text + " 서버에 연결 중";
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    socket.Connect(ipv4.Text, 3474);
                }
                catch
                {
                    disc = "off";
                    tcpinfo.Text = ipv4.Text + " 서버에 연결 실패";
                }
                
                //IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ipv4.Text), 3474);
                
                if (socket.Connected)
                {
                    tcpinfo.Text = ipv4.Text + " 서버가 연결되었습니다.";
                    disc = "on";
                    msg = "Hello World!";
                    byte[] buff = Encoding.UTF8.GetBytes(msg);
                    socket.Send(buff);
                    Application.DoEvents();
                    this.Size = new Size(948, 539);
                    minimum.Location = new Point(896, 3);
                    close.Location = new Point(925, 3);
                    serinfo.Text = "ip : " + ipv4.Text + "\n" + "port : 3474";
                    verify.Enabled = true;
                    reboot.Enabled = true;
                    serverstart.Enabled = true;
                    databk.Enabled = true;
                    export.Enabled = true;
                }
                
            } else
            {
                disc = "off";
                tcpinfo.Text = "서버 주소가 입력되지 않음";
            }
        }
        public string disc;
        private void Form6_Load(object sender, EventArgs e)
        {
            connection.Focus();
            verify.Enabled = false;
            reboot.Enabled = false;
            serverstart.Enabled = false;
            databk.Enabled = false;
            export.Enabled = false;
            this.Size = new Size(489, 539);
            minimum.Location = new Point(438, 3);
            close.Location = new Point(466, 3);
        }

        private void disconnetion_Click(object sender, EventArgs e)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if(disc == "on")
            {
                tcpinfo.Text = ipv4.Text + " 서버와의 연결 종료";
                //socket.Close();
                this.Size = new Size(489, 539);
                minimum.Location = new Point(438, 3);
                close.Location = new Point(466, 3);
            }
            
            
        }
        private void verify_Click(object sender, EventArgs e)
        {

        }

        private void minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

    }
}
