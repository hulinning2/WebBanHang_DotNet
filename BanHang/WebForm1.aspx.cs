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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.DataList1.RepeatColumns = 3;
            Class1 cs = new Class1();
            String madm = Request.QueryString.Get("madm");
            if (madm != null)
            {
                this.DataList1.DataSource = cs.getTable("SELECT * FROM DanhSachSanPham Where madm = " + madm);
            }
            else
            {
                this.DataList1.DataSource = cs.getTable("SELECT * FROM DanhSachSanPham");
            }

            String id = Request.QueryString.Get("id");
            int kt = Convert.ToInt32(id);
            if (kt < 0)
            {
                id = Math.Abs(kt).ToString();
                DataTable data = cs.getTable("SELECT * FROM DanhSachSanPham WHERE id = " + id);
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
            }
            this.DataList1.DataBind();
        }
    }
}