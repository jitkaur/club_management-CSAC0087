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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);            
            //TextBox1.Text = string.Empty;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string eml = TextBox1.Text;

                string qry = "select * from registration where email='" + eml + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    TextBox2.Text = (sdr["password"].ToString());
                    TextBox3.Text = (sdr["first"].ToString());
                    TextBox4.Text = (sdr["last"].ToString());
                    TextBox5.Text = (sdr["birth"].ToString());
                    DropDownList1.SelectedValue = (sdr["access"].ToString());
                    TextBox6.Text = (sdr["number"].ToString());
                    DropDownList2.SelectedValue = (sdr["department"].ToString());
                    TextBox7.Text = (sdr["address"].ToString());
                    TextBox8.Text = (sdr["address2"].ToString());

                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Check your data');", true);

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email does not exist');window.location.href='WebForm8.aspx';", true);
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
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string eml = TextBox1.Text;

                string qry = "select * from registration where email='" + eml + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    string uid = TextBox1.Text;
                    con.Open();
                    string qr = "select * from accessuser where Request_id='" + uid + "'; select * from auser where User_id='" + uid + "'";
                    SqlCommand cmnd = new SqlCommand(qr, con);
                    SqlDataReader sd = cmnd.ExecuteReader();
                    if (sd.Read())
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Access Request for this email has already been sent!');window.location.href='WebForm8.aspx';", true);
                    }
                    else
                    {
                        string abc = "Active";
                        string xyz = "Pending approval";

                        SqlConnection conec = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                        conec.Open();
                        string insertQuery = "insert into accessuser (Request_id, First_name, Last_name, department, Request_status)values (@requestid, @first, @last, @department, @request)";
                        SqlCommand cm = new SqlCommand(insertQuery, conec);
                        cm.Parameters.AddWithValue("@requestid", TextBox1.Text);
                        cm.Parameters.AddWithValue("@first", TextBox3.Text);
                        cm.Parameters.AddWithValue("@last", TextBox4.Text);
                        cm.Parameters.AddWithValue("@department", DropDownList2.SelectedValue);
                        cm.Parameters.AddWithValue("@request", abc);
                        cm.ExecuteNonQuery();

                        string insrtQury = "insert into auser (User_id, First_name, Last_name, Access_Type, Department)values (@userid, @firstn, @lastn, @access, @department)";
                        SqlCommand cms = new SqlCommand(insrtQury, conec);
                        cms.Parameters.AddWithValue("@userid", TextBox1.Text);
                        cms.Parameters.AddWithValue("@firstn", TextBox3.Text);
                        cms.Parameters.AddWithValue("@lastn", TextBox4.Text);
                        cms.Parameters.AddWithValue("@access", xyz);
                        cms.Parameters.AddWithValue("@department", DropDownList2.SelectedValue);
                        cms.ExecuteNonQuery();

                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Request for elevated access has been sent');window.location.href='WebForm8.aspx';", true);

                        conec.Close();
                    }
                    con.Close();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email does not exist');window.location.href='WebForm8.aspx';", true);
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