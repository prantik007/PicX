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
    public partial class WebForm8 : System.Web.UI.Page
    {
        string secq;
        string uname;

        protected void Page_Load(object sender, EventArgs e)
        {
            tb_error.Visible = false;
            
        }

        protected void btn_subrecovery_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-J1KVLUUSBIE;Initial Catalog=Photos;Persist Security Info=True;User ID=sa;password=12345");
            con.Open();

            string newcom = "select uname,secq from Users where uname='" + tb_unamerecovery.Text + "'";

            SqlDataAdapter adp = new SqlDataAdapter(newcom, con);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {
                btn_subrecovery1.Visible = true;
                btn_subrecovery.Visible = false;

                secq = dt.Rows[0]["secq"].ToString();
                uname = dt.Rows[0]["uname"].ToString();


            }

            else
            {
                tb_error.Text = "Username Not found";
                tb_error.Visible = true;
            }
        }

        protected void btn_subrecovery1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-J1KVLUUSBIE;Initial Catalog=Photos;Persist Security Info=True;User ID=sa;password=12345");
            con.Open();

            lbl_uname.Text = secq;

            string newcom = "select seca,pwd from Users where uname='"+uname+"'";

            SqlDataAdapter adp = new SqlDataAdapter(newcom, con);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {

                if (dt.Rows[0]["seca"].ToString() == tb_unamerecovery.Text)
                {
                    tb_error.Text = "Your password is : '" + dt.Rows[0]["pwd"].ToString() + "'";
                    tb_error.Visible = true;

                    tb_unamerecovery.Visible = false;
                    btn_subrecovery.Visible = false;
                    btn_subrecovery1.Visible = false;
                }

                else
                {
                    tb_error.Text = "wrong answer";
                    tb_error.Visible = true;
                
                }

            }

            else
            {
                tb_error.Text = "Username Not found";
                tb_error.Visible = true;
            }
        }
    }
}