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
    public partial class Customers : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress; initial catalog=NORTHWND; Trusted_Connection=true; ");

        public void comboboxdoldur()
        {

            if (!IsPostBack)
            {

                SqlCommand cmd = new SqlCommand("Select CustomerID,CompanyName From Customers", con);

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
                        ddCustomers.Items.Add(rd[0].ToString());

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

        protected void ddCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select CustomerID,CompanyName from   Customers where CustomerID='" + ddCustomers.SelectedItem.Text + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txtCustomerID.Text = rd[0].ToString();
                    txtCompanyName.Text = rd[1].ToString();
                   
                }
            }
            rd.Close();
            con.Close();
        }

        

        protected void btnCustomersGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update  Customers set CustomerID=@CustomerID,CompanyName=@CompanyName where CustomerID=@CustomerID", con);

            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int etkilenen = cmd.ExecuteNonQuery();
        }
    }
}