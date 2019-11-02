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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                string uid = TextBox1.Text;
                conn.Open();
                string qry = "select * from registration where email='" + uid + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email already exist!');window.location.href='WebForm6.aspx';", true);
                }
                else
                {
                    SqlConnection conec = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conec.Open();
                    string insertQuery = "insert into registration (email, password, first, last, birth, access, number, department, address, address2)values (@email, @password, @first, @last, @birth, @access, @number, @department, @address, @address2)";
                    SqlCommand cm = new SqlCommand(insertQuery, conec);
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
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('User added successfully');window.location.href='WebForm6.aspx';", true);

                    conec.Close();
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
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "window.location.href='WebForm6.aspx';", true);
        }
    }
}