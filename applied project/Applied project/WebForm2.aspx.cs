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
    public partial class WebForm2 : System.Web.UI.Page
    {
        //string cap = "";
        //int tot = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*  Random ra = new Random();
                int noc = ra.Next(6, 10);

               do
               {
                   int ch = ra.Next(48, 123);
                   if ((ch >= 48 && ch <= 57) || (ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122))
                   {
                       cap = cap + (char)ch;
                       tot++;
                       if (tot == noc)
                           break;
                   }
               }
               while (true);
               Label1.Text = cap;
               Label2.Text = Label1.Text; */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool isHuman = captchaBox.Validate(TextBox7.Text);
            TextBox7.Text = null;
            if (!isHuman)
            {
                //The Captcha entered by user is Invalid.
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Invalid captcha!');", true);
            }
            else
            {
                //The Captcha entered by user is Valid.
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    string uid = TextBox1.Text;
                    conn.Open();
                    string qry = "select * from signup where email='" + uid + "'";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email already exist!');window.location.href='WebForm2.aspx';", true);
                    }
                    /* else if(TextBox7.Text == "")
                     {                    
                         ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter Captcha!');window.location.href='WebForm2.aspx';", true);
                     }
                     else if( TextBox7.Text != Label2.Text)
                     {
                         Response.Write(TextBox7.Text);
                         Response.Write(Label2.Text);
                         //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter valid Captcha!');window.location.href='WebForm2.aspx';", true);
                     } */

                    else
                    {
                        SqlConnection conec = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                        conec.Open();
                        string insertQuery = "insert into signup (email, password, fname, lname, dob)values (@email, @password, @fname, @lname, @dob)";
                        SqlCommand cm = new SqlCommand(insertQuery, conec);
                        cm.Parameters.AddWithValue("@email", TextBox1.Text);
                        cm.Parameters.AddWithValue("@password", TextBox2.Text);
                        cm.Parameters.AddWithValue("@fname", TextBox4.Text);
                        cm.Parameters.AddWithValue("@lname", TextBox5.Text);
                        cm.Parameters.AddWithValue("@dob", TextBox6.Text);
                        cm.ExecuteNonQuery();

                        //Response.Write("Student registeration Successfully!!!thank you");
                        // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                        //Response.Write("<script>alert('username xjhsgvdckj, try another')</script>");
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Registration has been done successfully');window.location.href='WebForm1.aspx';", true);

                        conec.Close();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("error" + ex.ToString());
                }
            }
        }
    }    
}