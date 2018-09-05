using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Foodcourt
{
    public partial class Updatestock : Form
    {
        string sid = "sid_";

        public Updatestock()
        {
            InitializeComponent();
        }

        private void AutogenerateStockid()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i = a1.Autogenerateid("stocktransaction");
            sid = sid + i;
            textBox1.Text = sid;
        }
        private void AdditemTypes()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            DataSet ds = a1.BinditemTypes();
            cbitemtype.DataSource = ds.Tables[0];
            cbitemtype.DisplayMember = "itype";
            cbitemtype.ValueMember = "ityno";


        }

        /* private void label4_Click(object sender, EventArgs e)
         {

         }*/

        private void Updatestock_Load(object sender, EventArgs e)
        {
            AutogenerateStockid();
            AdditemTypes();
        }

        private void cbitemtypes_SelectedIndesxChnaged(object sender, EventArgs e)
        {
            /*Autogenerateclass a1 = new Autogenerateclass();
            DataSet ds = a1.Binditemnames(cbitemtype.SelectedValue.ToString());
            cbitemtype.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "iname";
            comboBox2.ValueMember = "ino"; */


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbitemtypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Autogenerateclass a1 = new Autogenerateclass();
            DataSet ds = a1.Binditemnames(cbitemtype.SelectedValue.ToString());
            cbitemtype.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "iname";
            comboBox2.ValueMember = "ino";

        }
    }
}
