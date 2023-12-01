using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitirmeProjesi
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        LOGINEntities1 db = new LOGINEntities1();
        public int Calculate()
        {
            int balance = 0;
            int checkedCount = 0;
            foreach (Control control in groupBox2.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkedCount++;
                }
            }
            balance = checkedCount * 5;
            if (cmb_potato_size.Text == "Küçük")
                balance += 5;
            else if (cmb_potato_size.Text == "Orta")
                balance += 7;
            else if (cmb_potato_size.Text == "Büyük")
                balance += 10;

            if (cmb_drink_size.Text == "Küçük")
                balance += 3;
            else if (cmb_drink_size.Text == "Orta")
                balance += 5;
            else if (cmb_drink_size.Text == "Büyük")
                balance += 7;
            balance += db.@params.FirstOrDefault(i => i.name == cmb_menu.Text).price;
            balance += db.@params.FirstOrDefault(i => i.name == cmb_drinks.Text).price;
            balance += db.@params.FirstOrDefault(i => i.name == cmb_snack.Text).price;
            return balance;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach(var item in db.@params.ToList())
            {
                if(item.type == "menu")
                    cmb_menu.Items.Add(item);
                else if(item.type == "Icecek")
                    cmb_drinks.Items.Add(item);
                else if (item.type == "Boyut")
                {
                    cmb_potato_size.Items.Add(item);
                    cmb_drink_size.Items.Add(item);
                }
                else if(item.type == "Snack")
                    cmb_snack.Items.Add(item);
            }
            cmb_snack.DisplayMember = "name";
            cmb_drinks.DisplayMember = "name";
            cmb_menu.DisplayMember = "name";
            cmb_drink_size.DisplayMember = "name";
            cmb_potato_size.DisplayMember = "name";
        }
        private void btn_order_Click(object sender, EventArgs e)
        {
            int calculation = Calculate();
            ListViewItem lviw = new ListViewItem();
            lviw.Text = cmb_menu.Text;
            lviw.SubItems.Add(cmb_potato_size.Text);
            lviw.SubItems.Add(cmb_drinks.Text);
            lviw.SubItems.Add(cmb_drink_size.Text);
            lviw.SubItems.Add(cmb_snack.Text);
            lviw.SubItems.Add(calculation.ToString());
            listView1.Items.Add(lviw);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                cmb_menu.Text = listView1.SelectedItems[0].SubItems[0].Text;
                cmb_potato_size.Text = listView1.SelectedItems[0].SubItems[1].Text;
                cmb_drinks.Text = listView1.SelectedItems[0].SubItems[2].Text;
                cmb_drink_size.Text = listView1.SelectedItems[0].SubItems[3].Text;
                cmb_snack.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = cmb_menu.Text;
                listView1.SelectedItems[0].SubItems[1].Text = cmb_potato_size.Text;
                listView1.SelectedItems[0].SubItems[2].Text = cmb_drinks.Text;
                listView1.SelectedItems[0].SubItems[3].Text = cmb_drink_size.Text;
                listView1.SelectedItems[0].SubItems[4].Text = cmb_snack.Text;
                listView1.SelectedItems[0].SubItems[5].Text = Calculate().ToString();
            }
        }
    }
}
