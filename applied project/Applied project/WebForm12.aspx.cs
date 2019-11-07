using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Applied_project
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Displaying the Data  
                showData();
            }
        }
        protected void showData()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapt = new SqlDataAdapter("select * from accessuser", con);
            con.Open();
            adapt.Fill(dt);
            con.Close();
            GridView1.DataSourceID = null;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }  
        protected void ApproveRecord(string id)
        {
            string abc = "Approved";
            string xyz = "Management";
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = new SqlCommand("update accessuser set Request_status = @xyz where Request_id =@ID", con);
            string insrtQuery = "update auser set Access_Type = '" + xyz + "'";
            string insrtQry = "update registration set access = '" + xyz + "'";
            SqlCommand cmd = new SqlCommand(insrtQuery, con);
            SqlCommand cnd = new SqlCommand(insrtQry, con);
            com.Parameters.AddWithValue("@xyz", abc);
            com.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@access", xyz);
            cnd.Parameters.AddWithValue("@access", xyz);
            con.Open();
            com.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            cnd.ExecuteNonQuery();
            con.Close();
        }
        protected void DeclineRecord(string id)
        {
            string abc = "Declined";
            string xyz = "Member";
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = new SqlCommand("update accessuser set Request_status = @xyz where Request_id =@ID", con);
            string insrtQuery = "update auser set Access_Type = '" + xyz + "'";
            string insrtQry = "update registration set access = '" + xyz + "'";
            SqlCommand cmd = new SqlCommand(insrtQuery, con);
            SqlCommand cnd = new SqlCommand(insrtQry, con);
            com.Parameters.AddWithValue("@xyz", abc);
            com.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@access", xyz);
            cnd.Parameters.AddWithValue("@access", xyz);
            con.Open();
            com.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            cnd.ExecuteNonQuery();
            con.Close();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow grow in GridView1.Rows)
            { 
                CheckBox CheckBox1 = (CheckBox)grow.FindControl("CheckBox1"); 
                if (CheckBox1.Checked)
                {
                    string id = Convert.ToString(grow.Cells[1].Text);
                    ApproveRecord(id);
                }
            }
            //Displaying the Data in GridView  
            showData();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow grow in GridView1.Rows)
            { 
                CheckBox CheckBox1 = (CheckBox)grow.FindControl("CheckBox1");
                if (CheckBox1.Checked)
                {
                    string id = Convert.ToString(grow.Cells[1].Text);
                    DeclineRecord(id);
                }
            }
            showData();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //data soure control that works with sql database
            SqlDataSource sds = new SqlDataSource();
            //get connection string from application's web.config file
            sds.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            //create parameters with specified name and values
            sds.SelectParameters.Add("Name", TypeCode.String, this.TextBox1.Text);
            //set the sql string to retrive data from the database
            sds.SelectCommand = "select * from accessuser where Request_id = @Name or First_Name = @Name or Last_Name=@Name";
            //retrive data
            DataView dv = (DataView)sds.Select(DataSourceSelectArguments.Empty);
            if (TextBox1.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter something for search');window.location.href='WebForm12.aspx';", true);
            }
            else if (dv.Count == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No record found!');window.location.href='WebForm12.aspx';", true);
            }
            else
            {
                GridView1.DataSourceID = null;
                GridView1.DataSource = sds;
                GridView1.DataBind();
            }
        }
    }
}