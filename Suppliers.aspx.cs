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
    public partial class Suppliers : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress; initial catalog=NORTHWND; Trusted_Connection=true; ");

        public void comboboxdoldur()
        {

            if (!IsPostBack)
            {

                SqlCommand cmd = new SqlCommand("Select SupplierID From Suppliers", con);

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
                        ddSuppliers.Items.Add(rd[0].ToString());

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

        protected void btnSuppliersGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update  Suppliers set CompanyName=@CompanyName,ContactName=@ContactName where SupplierID=@SupplierID", con);
            cmd.Parameters.AddWithValue("@SupplierID", txtSupplierID.Text);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
            cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int etkilenen = cmd.ExecuteNonQuery();
        }

        protected void ddSupliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select SupplierID,CompanyName,ContactName from   Suppliers where SupplierID='" + ddSuppliers.SelectedItem.Text + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txtSupplierID.Text = rd[0].ToString();
                    txtCompanyName.Text = rd[1].ToString();
                    txtContactName.Text = rd[2].ToString();
                }
            }
            rd.Close();
            con.Close();
        }
    }
}