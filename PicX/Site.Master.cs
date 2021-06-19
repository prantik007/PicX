using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PicX
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                MultiView_login.ActiveViewIndex = 0;
                lbl_loginerror.Visible = false;
            }

            if (Session["Username"] != null)
            {
                MultiView_login.ActiveViewIndex = 1;

                lbl_wc.Text = Session["Username"].ToString();
 
            }
        }

        protected void MultiView_login_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void btn_home_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Home.aspx",false);
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {


            Response.Redirect("Register.aspx",false);
        }

        protected void btn_contact_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx",false);
        }

        protected void btn_aboutus_Click(object sender, EventArgs e)
        {
            Response.Redirect("Aboutus.aspx",false);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=WIN-J1KVLUUSBIE;Initial Catalog=Photos;Persist Security Info=True;User ID=sa;password=12345");
            con.Open();

            string newcom = "select uname from Users where uname='" + tb_uname.Text + "' and pwd='" + tb_pw.Text + "'";

            SqlDataAdapter adp = new SqlDataAdapter(newcom, con);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {
                
                


                    MultiView_login.ActiveViewIndex = 1;
                    Session["username"] = tb_uname.Text;

                    lbl_wc.Text = tb_uname.Text;


                

            }

            else
            {
                lbl_loginerror.Text = "Invalid Credentials";
                lbl_loginerror.Visible = true;
            }


        }
    }
}