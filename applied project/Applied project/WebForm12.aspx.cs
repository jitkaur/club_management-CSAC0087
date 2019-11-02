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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // string abc = Session["Condtion"].ToString();           
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Condtion"] = "Access Request Approved";
            try
            {
                string abc = "Approve";

                SqlConnection conec = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conec.Open();
                string insertQuery = "update accessuser set Request_status = '" + abc + "'";
                SqlCommand cm = new SqlCommand(insertQuery, conec);
                cm.Parameters.AddWithValue("@request", abc);
                cm.ExecuteNonQuery();

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Request for elevated access has approved');window.location.href='WebForm12.aspx';", true);

                conec.Close();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["Condtion"] = "Access Request Declined";
            try
            {
                string abc = "Declined";

                SqlConnection conec = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conec.Open();
                string insertQuery = "update accessuser set Request_status = '" + abc + "'";
                SqlCommand cm = new SqlCommand(insertQuery, conec);
                cm.Parameters.AddWithValue("@request", abc);
                cm.ExecuteNonQuery();

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Request for elevated access has declined');window.location.href='WebForm12.aspx';", true);

                conec.Close();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}