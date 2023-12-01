using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitirmeProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LOGINEntities1 db = new LOGINEntities1();
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            var rec = db.datas.Where(a => a.username == username && a.password == password).FirstOrDefault();
            if (rec != null)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();
            register.Show();
        }
    }
}
