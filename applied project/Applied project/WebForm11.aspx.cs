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
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("user_id");
            dt.Columns.Add("first_name");
            dt.Columns.Add("last_name");
            dt.Columns.Add("access_type");
            dt.Columns.Add("department");
            foreach (GridViewRow item in GridView1.Rows)
            {
                if ((item.Cells[0].FindControl("CheckBox1") as CheckBox).Checked)
                {
                    DataRow dr = dt.NewRow();
                    dr["user_id"] = item.Cells[1].Text;
                    dr["first_name"] = item.Cells[2].Text;
                    dr["last_name"] = item.Cells[3].Text;
                    dr["access_type"] = item.Cells[4].Text;
                    dr["department"] = item.Cells[5].Text;
                    dt.Rows.Add(dr);
                }
            }
            // lblMsg.Visible = true;
            //GridView1.DataSourceID = null;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}