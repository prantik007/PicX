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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        protected void btn_reg_Click(object sender, EventArgs e)
        {
            int flag=0;

            if (tb_addr.Text == String.Empty || tb_cntno.Text == String.Empty || tb_email.Text == String.Empty || tb_fname.Text == String.Empty || tb_lname.Text == String.Empty || tb_pw.Text == String.Empty || tb_repw.Text == String.Empty || tb_sa.Text == String.Empty || tb_userid.Text == String.Empty)
            {
                lbl_error.Text = "Please fill all fields !";
                lbl_error.Visible = true;
                flag = 1;
            }




            else
            {

                SqlConnection con = new SqlConnection("Data Source=WIN-J1KVLUUSBIE;Initial Catalog=Photos;Persist Security Info=True;User ID=sa;password=12345");
                con.Open();

                string newcom = "select uname from Users where uname='" + tb_userid.Text + "'";

                SqlDataAdapter adp = new SqlDataAdapter(newcom, con);

                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count >= 1)
                {
                    lbl_error.Text = "User ID already exists";
                    lbl_error.Visible = true;
                    flag = 2;
                }
                    


                else if (string.Compare(tb_pw.Text, tb_repw.Text,true)==0)
                  {


                   

                        SqlConnection con1 = new SqlConnection("Data Source=WIN-J1KVLUUSBIE;Initial Catalog=Photos;Persist Security Info=True;User ID=sa;password=12345");
                        con1.Open();

                        string ipaddress;
                        ipaddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                        if (ipaddress == "" || ipaddress == null)
                        { ipaddress = Request.ServerVariables["REMOTE_ADDR"]; }

                        DateTime today = DateTime.Today;
                        string today_date = today.ToString("dd/MM/yyyy");

                        string newcom1 = "insert into Users(uname,pwd,fname,lname,addr,email,cntno,secq,seca,uip,ldate) VALUES ('" + tb_userid.Text + "','" + tb_pw.Text + "','" + tb_fname.Text + "','" + tb_lname.Text + "','" + tb_addr.Text + "','" + tb_email.Text + "','" + tb_cntno.Text + "','" + DropDownList_SQ.SelectedItem.Text + "','" + tb_sa.Text + "','" + ipaddress + "','" + today_date + "')";

                        SqlCommand cmd = new SqlCommand(newcom1, con1);

                        cmd.ExecuteNonQuery();

                        lbl_error.Text = "Registration done";
                        lbl_error.Visible = true;

                        tb_addr.Text = ""; tb_cntno.Text = ""; tb_email.Text = ""; tb_fname.Text = ""; tb_lname.Text = ""; tb_pw.Text = ""; tb_repw.Text = ""; tb_sa.Text = ""; tb_userid.Text = "";

                        con1.Close();
                }

                    else
                   {
                    lbl_error.Text = "Passwords don't match";
                    lbl_error.Visible = true;

                   }
                

                }
            }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            tb_addr.Text= ""; tb_cntno.Text= ""; tb_email.Text= ""; tb_fname.Text= ""; tb_lname.Text= ""; tb_pw.Text= ""; tb_repw.Text =""; tb_sa.Text= ""; tb_userid.Text="";
        }

          




                 
                    


                    
                
        


            


        
    }
}