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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_filter.Visible = false;
            lbl_selectalbum.Visible = false;

            DropDownList_album.Visible = false;
            DropDownList_category.Visible = false;
        }

        protected void btn_viewalb_Click(object sender, EventArgs e)
        {
            lbl_selectalbum.Visible = true;
            DropDownList_album.Visible = true;

            
        }

        protected void DropDownList_album_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbl_filter.Visible = true;
            DropDownList_category.Visible = true;


        }

        protected void btn_view_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewimage.aspx");
        }
    }
}