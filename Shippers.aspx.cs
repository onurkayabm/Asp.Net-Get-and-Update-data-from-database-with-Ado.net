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
    
    public partial class Shippers : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress; initial catalog=NORTHWND; Trusted_Connection=true; ");

        public void comboboxdoldur()
        {

            if (!IsPostBack)
            {

                SqlCommand cmd = new SqlCommand("Select ShipperID From Shippers", con);

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
                        ddShippers.Items.Add(rd[0].ToString());

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

        protected void ddShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ShipperID,CompanyName,Phone from   Shippers where ShipperID='" + ddShippers.SelectedItem.Text + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txtShippersID.Text = rd[0].ToString();
                    txtCompanyName.Text = rd[1].ToString();
                    txtPhone.Text = rd[2].ToString();
                }
            }
            rd.Close();
            con.Close();
        }

        protected void btnShippersGuncelle_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("update  Shippers set CompanyName=@CompanyName,Phone=@Phone where ShipperID=@ShipperID", con);
            cmd.Parameters.AddWithValue("@ShipperID", txtShippersID.Text);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int etkilenen = cmd.ExecuteNonQuery();
        }
    }
}