using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grid_view
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["con"].ToString();
            SqlConnection cn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from images",cn);
            DataSet ds = new DataSet(); 
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}