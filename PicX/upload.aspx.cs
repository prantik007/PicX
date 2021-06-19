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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_uploadsubmit_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(Server.MapPath(@"~/pictures/")))
            {
                System.IO.Directory.CreateDirectory(Server.MapPath(@"~/pictures/"));
            }

            else
            {
                String filePath = Server.MapPath(@"~/pictures/" + FU.FileName);
                FU.SaveAs(filePath);
            }

            DateTime today = DateTime.Today;
            string today_date = today.ToString("dd/MM/yyyy");
            
            SqlConnection con = new SqlConnection("Data Source=WIN-J1KVLUUSBIE;Initial Catalog=Photos;Persist Security Info=True;User ID=sa;password=12345");
            con.Open();



            string puid;
            string user = Session["username"].ToString();
            string newcome1 = "select uid from Users where uname='" + user + "'";
            SqlCommand cmd1 = new SqlCommand(newcome1, con);
            puid =cmd1.ExecuteScalar().ToString();
            
           

            string path= "~/pictures/" + FU.FileName;

            string newcom = "insert into Pics(ptitle,purl,pdesc,pdate,palbum,pcat,puid) VALUES ('" + tb_pictitle.Text + "','" + path + "','" + tb_picdesc.Text + "','" + today_date + "','" + DropDownList_album.SelectedValue + "','" + DropDownList_category.SelectedValue + "','"+puid+"')";
            

            SqlCommand cmd = new SqlCommand(newcom, con);
            

            cmd.ExecuteNonQuery();


        }
    }
}