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
using Newtonsoft.Json;

namespace vbEngC
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "9yMwkfkYIZDd39eyFUfLxZoFu8fjpks9SDb3yvSQ",
            BasePath = "https://mypro-a5ae4-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("there was problem in the internet.");
            }
            var Memlist = client.Get(@"Member");
            Member mlr = Memlist.ResultAs<Member>();
            memlist.ColumnCount = 5;
            memlist.Columns[0].Name = "이름";
            memlist.Columns[1].Name = "계정";
            memlist.Columns[2].Name = "등급";
            memlist.Columns[3].Name = "구독";
            memlist.Columns[4].Name = "비밀번호";
            memlist.Rows.Add(mlr.Name, mlr.ID, mlr.Grade, mlr.Sub, mlr.PW);
            MessageBox.Show("불러옴" + mlr.Name + "\n" + "구독" + mlr.Sub);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
