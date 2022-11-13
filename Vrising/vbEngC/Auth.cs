using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Windows.Forms;

namespace vbEngC
{
    public partial class Auth : UserControl
    {
        public Auth()
         {
             InitializeComponent();
         }

         private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
         {


         }
         IFirebaseConfig fcon = new FirebaseConfig()
         {
             AuthSecret = "9yMwkfkYIZDd39eyFUfLxZoFu8fjpks9SDb3yvSQ",
             BasePath = "https://mypro-a5ae4-default-rtdb.firebaseio.com/"
         };

         IFirebaseClient client;
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
                     if (ID.Text == waitmem.ID)
                     {
                         MessageBox.Show("발급 대기 중인 계정입니다.", "SMT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     } else
                     {
                         MessageBox.Show("아이디가 존재하지 않습니다.");
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
                         MessageBox.Show("발급 신청을 완료했습니다.\n관리자가 확인 중입니다..");
                         Form1 Login = new Form1();
                         Login.Show();
                         this.Hide();
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

         private void issue_Click(object sender, EventArgs e)
         {
             Form2 Register = new Form2();
             Register.StartPosition = FormStartPosition.CenterParent;
             Register.Show();
             this.Hide();
         }

         private void label8_Click(object sender, EventArgs e)
         {

         }

         private void AutoLogin_CheckedChanged(object sender, EventArgs e)
         {

         }

         private void label9_Click(object sender, EventArgs e)
         {

         }

         private void ID_TextChanged(object sender, EventArgs e)
         {

         }

         private void PW_TextChanged(object sender, EventArgs e)
         {

         }

         private void pictureBox2_Click(object sender, EventArgs e)
         {

         }

         private void label10_Click(object sender, EventArgs e)
         {

         }

         private void button1_Click(object sender, EventArgs e)
         {

         }

         private void label11_Click(object sender, EventArgs e)
         {

         }

         private void label7_Click(object sender, EventArgs e)
         {

         }

         private void label13_Click(object sender, EventArgs e)
         {

         }

     }
        
    }

