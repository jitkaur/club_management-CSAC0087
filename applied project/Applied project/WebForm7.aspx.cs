using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Applied_project
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                   string eml = TextBox1.Text;
                   string pas = TextBox2.Text;
                   string frst = TextBox3.Text;
                   string lst = TextBox4.Text;
                   string brt = TextBox5.Text;
                   string acs = DropDownList1.SelectedValue;
                   string nmbr = TextBox6.Text;
                   string drt = DropDownList2.SelectedValue;
                   string adrs = TextBox7.Text;
                   string adrs2 = TextBox8.Text;
               
                string qry = "select * from registration where email='" + eml + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    SqlConnection conec = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conec.Open();
                    string updateQuery = "update registration set password = '" + pas + "', first = '" + frst + "', last = '" + lst + "', birth = '" + brt + "', access = '"
                   + acs + "', number = '" + nmbr + "', department = '" + drt + "', address = '" + adrs + "', address2 = '" + adrs2 + "' where email = '" + eml + "'";
                    SqlCommand cm = new SqlCommand(updateQuery, conec);
                    cm.Parameters.AddWithValue("@email", TextBox1.Text);
                    cm.Parameters.AddWithValue("@password", TextBox2.Text);
                    cm.Parameters.AddWithValue("@first", TextBox3.Text);
                    cm.Parameters.AddWithValue("@last", TextBox4.Text);
                    cm.Parameters.AddWithValue("@birth", TextBox5.Text);
                    cm.Parameters.AddWithValue("@access", DropDownList1.SelectedValue);
                    cm.Parameters.AddWithValue("@number", TextBox6.Text);
                    cm.Parameters.AddWithValue("@department", DropDownList2.SelectedValue);
                    cm.Parameters.AddWithValue("@address", TextBox7.Text);
                    cm.Parameters.AddWithValue("@address2", TextBox8.Text);
                    cm.ExecuteNonQuery();

                    //Response.Write("Student registeration Successfully!!!thank you");
                    // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                    //Response.Write("<script>alert('username xjhsgvdckj, try another')</script>");
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('User updated successfully');window.location.href='WebForm7.aspx';", true);

                    conec.Close();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email does not exist');window.location.href='WebForm7.aspx';", true);
                }  
                    conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "window.location.href='WebForm7.aspx';", true);
        }
    }
}