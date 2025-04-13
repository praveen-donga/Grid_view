using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Grid_view
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["con"].ToString();  
            SqlConnection cn=new SqlConnection(str);    
            SqlDataAdapter da =new SqlDataAdapter("select * from student",cn);
            DataSet ds = new DataSet();  
            da.Fill(ds);                 
            GridView1.DataSource = ds;
            GridView1.DataBind();

            //Using DataTable:
            /* DataTable dt=new DataTable();
               da.Fill(dt);
               GridView1.DataSource = dt; 
               GridView1.DataBind();  */
        }
    }
}