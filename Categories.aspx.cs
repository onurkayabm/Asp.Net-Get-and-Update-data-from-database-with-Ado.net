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
    public partial class Categories : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress; initial catalog=NORTHWND; Trusted_Connection=true; ");

        public void comboboxdoldur() {

            if (!IsPostBack)
            {

                SqlCommand cmd = new SqlCommand("Select CategoryID,CategoryName From Categories", con);

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
                        ddCategories.Items.Add(rd[0].ToString());

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

        protected void ddCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                SqlCommand cmd = new SqlCommand("select CategoryID,CategoryName,Description from   Categories where CategoryID='"+ddCategories.SelectedItem.Text+"'", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        txtCategoryID.Text = rd[0].ToString();
                        txtCategoryName.Text = rd[1].ToString();
                        txtDescription.Text = rd[2].ToString();
                    }
                }
                rd.Close();
                con.Close();
            
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update  Categories set CategoryName=@CategoryName,Description=@Description where CategoryID=@CategoryID", con);
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
            cmd.Parameters.AddWithValue("@CategoryID", txtCategoryID.Text);
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
          int etkilenen=  cmd.ExecuteNonQuery();
            
            
            
        }
    }
}