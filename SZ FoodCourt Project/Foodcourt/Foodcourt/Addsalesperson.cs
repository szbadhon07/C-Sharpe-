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
    public partial class Addsalesperson : Form
    {
        string eno = "eno_";
        
        public Addsalesperson()
        {
            InitializeComponent();
        }
        private void AutogenerateEmpno()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i = a1.Autogenerateid("employee");
            eno = eno + i;
            txteno.Text = eno;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
                //open the connection
                con.Open();
                //pass the procedure
                SqlCommand cmd = new SqlCommand("proc_createemployee", con);
                //metion what we are stored in procedure
                cmd.CommandType = CommandType.StoredProcedure;

                //pass the values to the parameters
                MessageBox.Show("Before query!");
                cmd.Parameters.AddWithValue("@eid", txteno.Text);
                cmd.Parameters.AddWithValue("@ename", txtename.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd.Parameters.AddWithValue("@phoneno", txtphoneno.Text);
                cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@hint", txthint.Text);
                //exceute the procedure
                int i = cmd.ExecuteNonQuery();
                //close the connection
                con.Close();
                if (i==1)
                {
                    MessageBox.Show(txtename.Text + "is added");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                eno = "eno_";
                txtename.Text = "";
                AutogenerateEmpno();

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);

            }
            

        }
        private void Addsalesperson_Load(object sender, EventArgs e)
        {
            AutogenerateEmpno();


        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
