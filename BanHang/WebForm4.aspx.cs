using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using BanHang.App_Code;

namespace BanHang
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOGIN"] != null)
            {
                Response.Redirect("WebForm3.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Class1 C = new Class1();
            DataTable data = C.getTable("select * from Acc where username = '" + txtUserName.Text + "' and pass = '" + txtPassWord.Text + "'");
            Response.Write("<script>console.log(" + "'select * from Acc where username = " + txtUserName.Text + " and pass = " + txtPassWord.Text + "');</script>");
            if (data.Rows.Count > 0)
            {
                Session.Timeout = 2;
                Session["LOGIN"] = data;
                Response.Redirect("WebForm3.aspx");
            }
            else
            {
                Response.Redirect("WebForm1.aspx");
            }
        }
    }
}