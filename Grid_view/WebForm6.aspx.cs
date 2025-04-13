using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Grid_view
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                GetData();
            }
        }


       void GetData()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
            string q = "select * from student";
            SqlDataAdapter da = new SqlDataAdapter(q,cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q = "";
            if (Button1.Text == "Insert")
            {
                q = "insert into student values('" + TextBox1.Text +"','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text +"')";

            }
            else if (Button1.Text == "Update")
            {
               q = "update student set pwd='" + TextBox2.Text + "',email='" + TextBox3.Text + "',phone=" + TextBox4.Text + " where username ='" +TextBox1.Text+"'";
            }
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(q,con);
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Button1.Text= "Insert";

        }

       

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "cmdEdit")
            {
                int index=Convert.ToInt32(e.CommandArgument);
                GridViewRow row= GridView1.Rows[index];
                Label a= (Label)row.FindControl("Label1");
                Label b = (Label)row.FindControl("Label2");
                Label c = (Label)row.FindControl("Label3");
                Label d = (Label)row.FindControl("Label4");
                TextBox1.Text=a.Text;
                TextBox2.Text = b.Text;
                TextBox3.Text = c.Text;
                TextBox4.Text = d.Text;
                Button1.Text = "Update";
            }
            else if(e.CommandName == "cmdDelete")
            {
                int index=Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                Label a = (Label)row.FindControl("Label1");
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
                con.Open();
                string q="delete from student where username='"+a.Text+"'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                GetData();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}