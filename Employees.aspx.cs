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
    public partial class Employees : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress; initial catalog=NORTHWND; Trusted_Connection=true; ");

        public void comboboxdoldur()
        {

            if (!IsPostBack)
            {

                SqlCommand cmd = new SqlCommand("Select EmployeeID,LastName,FirstName From Employees", con);

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
                        ddEmployee.Items.Add(rd[0].ToString());

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

        protected void btnEmployeeGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update  Employees set LastName=@LastName,FirstName=@FirstName where EmployeeID=@EmployeeID", con);
            cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
            cmd.Parameters.AddWithValue("@LastName", txtEmployeeLastName.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtEmployeeFirstName.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int etkilenen = cmd.ExecuteNonQuery();
        }

        protected void ddEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select EmployeeID,LastName,FirstName from   Employees where EmployeeID='" + ddEmployee.SelectedItem.Text + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    txtEmployeeID.Text = rd[0].ToString();
                    txtEmployeeLastName.Text = rd[1].ToString();
                    txtEmployeeFirstName.Text = rd[2].ToString();
                }
            }
            rd.Close();
            con.Close();
        }
    }
}