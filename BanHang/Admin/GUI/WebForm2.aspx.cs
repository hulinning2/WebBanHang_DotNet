using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BanHang.Admin;

namespace BanHang.Admin.GUI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        PRO.pro pro;
        protected void Page_Load(object sender, EventArgs e)
        {
            pro = new PRO.pro(this);
            pro.DoDuLIeu();
            pro.AllSanPhma();
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            pro.Them();
            pro.AllSanPhma();
        }

        protected void Unnamed7_Click(object sender, EventArgs e)
        {
            pro.Update();
            pro.AllSanPhma();

        }

        protected void Unnamed8_Click(object sender, EventArgs e)
        {
            pro.Delete();
            pro.AllSanPhma();

        }
    }
}