using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodcourt
{
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text=="")
            {
                MessageBox.Show("username must not be empty");
                txtusername.Focus();
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if(txtpassword.Text=="")
            {
                MessageBox.Show("password must not be empty");
                txtpassword.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5; //min value 0 max 5
            if(progressBar1.Value>=100)
            {
                timer1.Enabled = false;
                Adminhome a1 = new Adminhome();
                a1.Show();
            }
            
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text=="admin"&& txtpassword.Text=="admin")
            {
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("invalid user or password");
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
