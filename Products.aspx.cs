using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20170511_OdevMasterPage
{
    public partial class Products : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress; initial catalog=NORTHWND; Trusted_Connection=true; ");

        public void comboboxdoldur()
        {

            if (!IsPostBack)
            {

                SqlCommand cmd = new SqlCommand("Select ProductID From Products", con);

                con.Open();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlDataReader rd = cmd.ExecuteReader();


                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        ddProduct.Items.Add(rd[0].ToString());

                    }
                }
                rd.Close();
                con.Close();
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            comboboxdoldur();
        }

        protected void btnProductGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update  Products set ProductName=@ProductName,UnitPrice=@UnitPrice where ProductID=@ProductID", con);
            cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
            cmd.Parameters.AddWithValue("@UnitPrice", txtUnitPrice.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int etkilenen = cmd.ExecuteNonQuery();
           
        }

        protected void ddProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ProductID,ProductName,UnitPrice from   Products where ProductID='" + ddProduct.SelectedItem.Text + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txtProductID.Text = rd[0].ToString();
                    txtProductName.Text = rd[1].ToString();
                    txtUnitPrice.Text = rd[2].ToString();
                }
            }
            rd.Close();
            con.Close();
        }
    }
}