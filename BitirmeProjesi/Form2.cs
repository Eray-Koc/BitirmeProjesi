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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        LOGINEntities1 db = new LOGINEntities1();
        private void btn_rgs_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rgs_Click(object sender, EventArgs e)
        {
            datas obj = new datas();
            obj.name = txt_rgs_name.Text;
            obj.surname = txt_rgs_surname.Text;
            obj.username = txt_rgs_username.Text;
            obj.password = txt_rgs_password.Text;
            obj.address = txt_rgs_address.Text;
            obj.phonenumber = txt_rgs_phonenumber.Text;
            obj.mail = txt_rgs_mail.Text;
            db.datas.Add(obj);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");
            txt_rgs_name.Clear();
            txt_rgs_surname.Clear();
            txt_rgs_username.Clear();
            txt_rgs_password.Clear();
            txt_rgs_address.Clear();
            txt_rgs_phonenumber.Clear();
            txt_rgs_mail.Clear();
            txt_rgs_username.Focus(); 
        }
    }
}
