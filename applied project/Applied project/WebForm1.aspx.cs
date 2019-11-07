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
    public partial class WebForm1 : System.Web.UI.Page
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
                string pass = TextBox2.Text;
                conn.Open();
                string qry = "select * from signup where email='" + uid + "' and password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.Read())
                {                    
                    if (TextBox1.Text == "admin@gmail.com")
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Login has been done successfully');window.location.href='admin/WebForm3.aspx';", true);
                    }
                    else if(TextBox1.Text == "elevator@gmail.com")
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Login has been done successfully');window.location.href='middleware/WebForm4.aspx';", true);
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Login has been done successfully');window.location.href='WebForm5.aspx';", true);
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Failed !');window.location.href='WebForm1.aspx';", true);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "window.location.href='WebForm2.aspx';", true);
        }
    }  
}