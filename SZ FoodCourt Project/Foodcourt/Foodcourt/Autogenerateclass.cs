using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Foodcourt
{
    class Autogenerateclass
    {
        public int Autogenerateid (string tablename)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from "+ tablename ,con);
            int i = Convert.ToInt32(cmd.ExecuteScalar()); //data retrive korar jonno dorkar 
            i++;
            return i;
        }

        public DataSet BinditemTypes()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from itemmaster",con);
            DataSet ds = new DataSet();
            da.Fill(ds,"itemmaster");
            return ds;


        }
        public DataSet Binditemnames(string itypeno)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from items where ityno="+itypeno+"", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "items");
            return ds;


        }



    }
}
