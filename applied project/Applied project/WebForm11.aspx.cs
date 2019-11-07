using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Applied_project
{
    public partial class WebForm11 : System.Web.UI.Page
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
            SqlDataAdapter adapt = new SqlDataAdapter("select * from auser", con);
            con.Open();
            adapt.Fill(dt);
            con.Close();
            GridView1.DataSourceID = null;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        //Method for Deleting Record
        protected void DeleteRecord(string id)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlCommand com = new SqlCommand("delete from auser where User_Id =@ID", con);
            com.Parameters.AddWithValue("@ID", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
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
            sds.SelectCommand = "select * from auser where User_Id = @Name or First_Name = @Name or Last_Name=@Name";
            //retrive data
            DataView dv = (DataView)sds.Select(DataSourceSelectArguments.Empty);
            if (TextBox1.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter something for search');window.location.href='WebForm11.aspx';", true);
            }
            else if (dv.Count == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No record found!');window.location.href='WebForm11.aspx';", true);
            }
            else
            {
                GridView1.DataSourceID = null;
                GridView1.DataSource = sds;
                GridView1.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow grow in GridView1.Rows)
            {
                //Searching CheckBox("chkDel") in an individual row of Grid  
                CheckBox CheckBox1 = (CheckBox)grow.FindControl("CheckBox1");
                //If CheckBox is checked than delete the record with particular id  
                if (CheckBox1.Checked)
                {
                    string id = Convert.ToString(grow.Cells[1].Text);
                    DeleteRecord(id);
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('User has been deleted successfully!');window.location.href='WebForm11.aspx';", true);
                }
            }
            //Displaying the Data in GridView  
            showData();
        }
    }
}