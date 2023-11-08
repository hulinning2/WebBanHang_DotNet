using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BanHang.App_Code;

namespace BanHang
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        public void LoadCart()
        {
            if (Session["CART"] != null)
            {
                CART cart = (CART)Session["CART"];
                this.GridView1.DataSource = cart.LISTCARTS.Values.ToList();
                this.GridView1.DataBind();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCart();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["CART"] != null)
            {
                CART cart = (CART)Session["CART"];
                foreach (GridViewRow row in GridView1.Rows)
                {
                    CheckBox cb = (CheckBox)row.FindControl("CheckBox1");
                    if (cb.Checked)
                    {
                        String masp = row.Cells[0].Text;
                        cart.RemoveCart(masp);
                    }
                }
                Session["CART"] = cart;
                LoadCart();
            }
        }
    }
}
