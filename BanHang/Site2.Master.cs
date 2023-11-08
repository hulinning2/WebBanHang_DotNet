using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BanHang.App_Code;

namespace BanHang
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = "0";
            Label2.Text = "0";

            if (Session["CART"] != null)
            {
                CART cart = (CART)Session["CART"];
                int n = cart.LISTCARTS.Values.Count();
                Label1.Text = n.ToString();
                Label2.Text = cart.TotalBill().ToString();

            }

            Class1 C = new Class1();
            this.Repeater1.DataSource = C.getTable("SELECT * FROM DANHMUCSANPHAM");
            this.Repeater1.DataBind();
            this.Repeater2.DataSource = C.getTable("SELECT * FROM DANHMUCSANPHAM");
            this.Repeater2.DataBind();
        }
    }
}