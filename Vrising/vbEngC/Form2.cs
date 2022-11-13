using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace vbEngC
{
    public partial class Form2 : Form
    {
        bool On;
        Point Pos;
        public Form2()
        {
            InitializeComponent();
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "9yMwkfkYIZDd39eyFUfLxZoFu8fjpks9SDb3yvSQ",
            BasePath = "https://mypro-a5ae4-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;


        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("there was problem in the internet.");
            }
        }
        private void register_Click(object sender, EventArgs e)
        {
            int Mem = 1;
            if (namebox.Text != "" && idbox.Text != "" && pwbox.Text != "")
            {
                var setter1 = client.Get("Wait/" + idbox.Text);
                Student std1 = setter1.ResultAs<Student>();
               
                if (std1 == null)
                {
                    if (pwbox.Text == pwconbox.Text)
                    {
                        string password = pwbox.Text;
                        string EnPW = Encryption.SHA256Hash(password);
                        //MessageBox.Show(EnPW);
                        Student std = new Student()
                        {
                            Name = namebox.Text,
                            ID = idbox.Text,
                            PW = EnPW,
                            Grade = Mem.ToString(),
                        };
                        var setter = client.Set("Wait/" + idbox.Text, std);
                        MessageBox.Show("발급 신청을 완료했습니다.\n관리자가 확인 중입니다.");
                        Form1 Login = new Form1();
                        Login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("이미 존재하거나 발급 대기 중인 계정입니다.");
                }
            }
            else
            {
                MessageBox.Show("닉네임 또는 아이디와 비밀번호를 확인해주세요.");
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
