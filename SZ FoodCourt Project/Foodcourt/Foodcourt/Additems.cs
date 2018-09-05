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
    public partial class Additems : Form
    {
        string ino = "ino_";
        public Additems()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AutogenerateItemno()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            int i = a1.Autogenerateid("items");
            ino = ino + i;
            txtitemno.Text = ino;
        }

        private void Additems_Load(object sender, EventArgs e)
        {

            AutogenerateItemno();
            AdditemTypes();
            
            /*Autogenerateclass a1 = new Autogenerateclass();
            int i=a1.Autogenerateid("items");
            ino = ino + i;
            txtitemno.Text = ino;
            Additemtypes(); */

        }
        
        private void AdditemTypes()
        {
            Autogenerateclass a1 = new Autogenerateclass();
            DataSet ds= a1.BinditemTypes();
            cbitemtype.DataSource = ds.Tables[0];
            cbitemtype.DisplayMember = "itype";
            cbitemtype.ValueMember = "ityno";

        }

        private void clearAllField()
        {
            ino = "ino_";
            txtitemname.Clear();
            txtitemno.Clear();
            txtitemprice.Clear();
        }

        private Boolean ValidateForm()
        {   
            if (txtitemno.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Item No Can't be Blank");
                return false;
            }
            else if (txtitemname.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please Enter Item Name");
                return false;
            }
            else if (txtitemprice.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please Enter Item Price");
                return false;
            }
            else if (txtitemprice.Text.Trim() != String.Empty)
            {
                double itemPrice;
                double.TryParse(txtitemprice.Text.Trim().ToString(), out itemPrice);
                if (itemPrice <= 0)
                {
                    MessageBox.Show("Item Price Can't be Less than or equal to Zero, Please Enter the correct Price");
                    return false;
                }
            }
            return true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //create the connection
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
                //open the connection
                con.Open();
                //pass the procedure
                SqlCommand cmd = new SqlCommand("proc_additems", con);
                //mention that we are working with storedprocedure
                cmd.CommandType = CommandType.StoredProcedure;
                //pass the values to the parameters
                cmd.Parameters.AddWithValue("@ino", txtitemno.Text);
                cmd.Parameters.AddWithValue("@iname", txtitemname.Text);
                cmd.Parameters.AddWithValue("@qty", 0);
                cmd.Parameters.AddWithValue("@price", double.Parse(txtitemprice.Text.ToString()));
                cmd.Parameters.AddWithValue("@ityno", cbitemtype.SelectedValue.ToString());

                //execute the procedure
                int i = cmd.ExecuteNonQuery();
                //close the connection
                con.Close();

                if (i == 1)
                {
                    MessageBox.Show(txtitemname.Text + " is added Successfully.");
                    clearAllField();
                    AutogenerateItemno();
                }
                else
                {
                    MessageBox.Show("failed");

                }
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Adminhome a1 = new Adminhome();
            a1.Show();
        }
    }
}
