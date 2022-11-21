using System;
using System.Drawing;
using FireSharp.Config;
using System.IO;
using FireSharp.Interfaces;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace vbEngC
{

    public partial class Form1 : Form
    {
        bool On;
        Point Pos;
        public Form1()
        {
            InitializeComponent();
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }


        
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = "https://mypro-a5ae4-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            try 
             {
                 client = new FireSharp.FirebaseClient(fcon);
             }
             catch
             {
                 MessageBox.Show("인터넷에 연결되어 있지 않습니다.");
             }
            string path = "C:\\Auto.txt";
            FileInfo AutoFile = new FileInfo(path);
            if (AutoFile.Exists)
            {
                AutoLogin.Checked = true;
                StreamReader inauto = new StreamReader(path);
                string AutoData = File.ReadAllText(path);
                string[] AutoData_split = AutoData.Split(' ');
                ID.Text = AutoData_split[0];
                PW.Text = AutoData_split[1];
                Login.Focus();

                // MessageBox.Show(AutoData_ID[0] + "\n" + AutoData_PW[1]);
            }
        }



        private void Login_Click(object sender, EventArgs e)
        {
            if (ID.Text != "" && PW.Text != "")
            {
                string password = PW.Text;
                string EnPW = Encryption.SHA256Hash(password);
                var setter = client.Get("Member/" + ID.Text);
                Student std = setter.ResultAs<Student>();
                var wait = client.Get("Wait/" + ID.Text);
                Student waitmem = wait.ResultAs<Student>();
                string Grade = null;
                if (std == null)
                {
                    if (waitmem == null)
                    {
                        MessageBox.Show("아이디가 존재하지 않습니다.");
                    }
                    else
                    {
                        MessageBox.Show("발급 대기 중인 계정입니다.", "SMT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    if (ID.Text == std.ID && EnPW == std.PW)
                    {
                        if (std.Grade == "0")
                        {
                            Grade = "관리자";
                        }
                        else
                        {
                            Grade = "회원";
                        }
                        if (AutoLogin.Checked == true)
                        {
                            string path = "C:\\Auto.txt";
                            FileInfo AutoFile = new FileInfo(path);
                            string OID = ID.Text;
                            string OPW = PW.Text;
                            if (AutoFile.Exists)
                            {
                                AutoFile.Delete();
                                StreamWriter Out = new StreamWriter(path);
                                Out.WriteLine(OID + " " + OPW);
                                Out.Close();
                            } 
                            else
                            {
                                StreamWriter Out = new StreamWriter(path);
                                Out.WriteLine(OID + " " + OPW);
                                Out.Close();
                            }
                        } 
                        else
                        {

                        }
                        MessageBox.Show(std.Name + "님 방문을 환영합니다.\n" + std.Name + "님의 등급은 " + Grade + "입니다.");
                        Form3 Dashboard = new Form3();
                        Dashboard.StartPosition = FormStartPosition.CenterParent;
                        Dashboard.Show();
                        this.Hide();
                    }
                    else
                    {

                        MessageBox.Show("아이디 혹은 비밀번호를 확인하여 주십시오.");
                    }
                }
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 입력되지 않았습니다.");
            }
        }

        private void wellcome_Click(object sender, EventArgs e)
        {
            
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            Login_Click(sender, e);
            this.Close();
            Application.Exit();
        }

        private void issue_Click(object sender, EventArgs e)
        {
            
            Form2 Register = new Form2();
            Register.StartPosition = FormStartPosition.CenterParent;
            Register.Show();
            this.Hide();
            MessageBox.Show("디스코드 : 네트워크#9832");
        }
    }
}
