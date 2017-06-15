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
    public partial class Orders : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress; initial catalog=NORTHWND; Trusted_Connection=true; ");

        public void comboboxdoldur()
        {

            if (!IsPostBack)
            {

                SqlCommand cmd = new SqlCommand("Select OrderID From Orders", con);

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
                        ddOrder.Items.Add(rd[0].ToString());

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

        protected void ddOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select OrderID,ShipVia,Freight from   Orders where OrderID='" + ddOrder.SelectedItem.Text + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txtOrderID.Text = rd[0].ToString();
                    txtShipVia.Text = rd[1].ToString();
                    txtFreight.Text = rd[2].ToString();
                }
            }
            rd.Close();
            con.Close();
        }

        protected void btnOrderGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update  Orders set ShipVia=@ShipVia,Freight=@Freight where OrderID=@OrderID", con);
            cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text);
            cmd.Parameters.AddWithValue("@ShipVia", txtShipVia.Text);
            cmd.Parameters.AddWithValue("@Freight", txtFreight.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int etkilenen = cmd.ExecuteNonQuery();


          
        }
    }
}