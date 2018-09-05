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
    public partial class Additemtypes : Form
    {
        string itemtyno = "it_";
        public Additemtypes()
        {
            InitializeComponent();
        }

        private void AutogenerateItemtypeno()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i=a1.Autogenerateid("itemmaster");
            itemtyno= itemtyno + i; //string+index
            txttypeno.Text = itemtyno;
        }

        private void Additemtypes_Load(object sender, EventArgs e)
        {
            AutogenerateItemtypeno();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create the connection
            SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            //open the connection
            con.Open();
            //pass the procedure
            SqlCommand cmd = new SqlCommand("proc_additemtypes", con);
            //mention that we are working with storedprocedure
            cmd.CommandType = CommandType.StoredProcedure;
            //pass the values to the parameters
            cmd.Parameters.AddWithValue("@ityno", txttypeno.Text);
            cmd.Parameters.AddWithValue("@itype", txttypeno.Text);

            //exectue the procedure
            int i = cmd.ExecuteNonQuery();
            //close the connection
            con.Close();

            if(i==1)
            {
                MessageBox.Show(txttype.Text + " is added");

            }
            else
            {
                MessageBox.Show( "Failed");

            }
            string itemtyno = "it_";
            txttype.Text = "";
            AutogenerateItemtypeno();








        }
    }
}
