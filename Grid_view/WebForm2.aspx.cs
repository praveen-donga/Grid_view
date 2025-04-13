using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Grid_view
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["con"].ToString();
            SqlConnection cn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from student", cn);
            DataSet ds= new DataSet();    
            da.Fill(ds);
            if (Cache["Mydata"] == null)
            {
                Cache["Mydata"] = ds;
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Label1.Text = "From Server";
            }
            else
            {
                GridView1.DataSource = Cache["Mydata"];
                GridView1.DataBind();
                Label1.Text = "From Cache";
            }

        }
    }
}