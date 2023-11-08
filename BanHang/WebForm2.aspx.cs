using BanHang.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BanHang
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Class1 C = new Class1();
            String id = Request.QueryString.Get("id");
            int kt = Convert.ToInt32(id);
            if (kt > 0)
            {
                this.Repeater1.DataSource = C.getTable("SELECT * FROM DanhSachSanPham WHERE id = " + id);
                this.Repeater1.DataBind();
            }
            else
            {
                id = Math.Abs(kt).ToString();
                DataTable data = C.getTable("SELECT * FROM DanhSachSanPham WHERE id = " + id);
                if (Session["CART"] != null)
                {
                    CART cart = (CART)Session["CART"];
                    foreach (DataRow row in data.Rows)
                    {
                        cart.AddCart(row[0].ToString(), row[1].ToString(), row[2].ToString(), 1, Convert.ToDouble(row[3].ToString()));
                    }
                    Session["CART"] = (CART)(cart);
                }
                else
                {
                    CART cart = new CART();
                    foreach (DataRow row in data.Rows)
                    {
                        Response.Write("<script>console.log(" + row[0].ToString() + ");</script>");
                        cart.AddCart(row[0].ToString(), row[1].ToString(), row[2].ToString(), 1, Convert.ToDouble(row[3].ToString()));
                    }
                    Session["CART"] = (CART)(cart);
                }
                this.Repeater1.DataSource = data;
                this.Repeater1.DataBind();
            }
        }

    }
}