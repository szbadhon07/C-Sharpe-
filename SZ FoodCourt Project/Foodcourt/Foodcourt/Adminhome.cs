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
    public partial class Adminhome : Form
    {
        public Adminhome()
        {
            InitializeComponent();
        }

        private void iTEMTYPESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additemtypes a1 = new Additemtypes();
            a1.Show();
        }



        private void iTEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additems a1 = new Additems();
            a1.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Adminlogin a1= new Adminlogin();
            a1.Show();
        }

        private void salesmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addsalesperson a1 = new Addsalesperson();
            a1.Show();
        }

        private void uPDATESTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updatestock a1 = new Updatestock();
            a1.Show();

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
