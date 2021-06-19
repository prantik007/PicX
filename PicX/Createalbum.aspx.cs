using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PicX
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_createdalbum.Visible = false;
        }

        protected void btn_create_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-J1KVLUUSBIE;Initial Catalog=Photos;Persist Security Info=True;User ID=sa;password=12345");
            con.Open();

            string uname = Session["Username"].ToString();

            string newcom1 = "select uid from Users where uname='" + uname + "'";
            SqlCommand cmd1 = new SqlCommand(newcom1, con);
            string auid = cmd1.ExecuteScalar().ToString();

            string newcom="insert into Albums( aname,adesc,atype,auid) VALUES ('"+tb_albumname.Text+"','"+tb_albumdesc.Text+"','"+DropDownList1.SelectedValue+"','"+auid+"')";
            SqlCommand cmd = new SqlCommand(newcom, con);

            cmd.ExecuteNonQuery();

            lbl_createdalbum.Visible = true;
        }
    }
}