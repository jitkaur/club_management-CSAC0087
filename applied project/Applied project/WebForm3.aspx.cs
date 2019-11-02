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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                
                conn.Open();
                string qry = "select fname, lname from signup";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.Read())
                {                    
                    Label1.Text = sdr.GetString(0);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}