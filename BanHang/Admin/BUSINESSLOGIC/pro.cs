using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using BanHang.Admin.CONT;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace BanHang.Admin.PRO
{
    public class pro
    {
        Class1 class1;
        Page page;

        public pro(Page page1)
        {
            page = page1;
            class1 = new Class1();
        }
        public void DoDuLIeu()
        {
            DropDownList danhmuc = (DropDownList)page.FindControl("DropDownList1");
            if (danhmuc == null)
            {
                danhmuc = (DropDownList)page.FindControl("ContentPlaceHolder1_DropDownList1");
            }
            danhmuc.DataSource = class1.getDanhMuc();
            danhmuc.DataTextField = "ten";
            danhmuc.DataValueField = "madm";
            danhmuc.DataBind();
        }

        public void AllSanPhma()
        {
            GridView sanpham = (GridView)page.FindControl("GridView1111");
            if (sanpham == null)
            {
                sanpham = (GridView)page.FindControl("ContentPlaceHolder1_GridView1111");
            }
            sanpham.DataSource = class1.getSanPham();
            sanpham.DataBind();
        }
        public String UploadAnh()
        {
            FileUpload fileupload = ((FileUpload)page.FindControl("FileUpload1"));
            String fileName = null;
            if (fileupload.HasFile)
            {
                fileName = fileupload.FileName;
                String path = this.page.Server.MapPath("\\images\\");
                fileupload.PostedFile.SaveAs(path + fileName);
            }
            return fileName;
        }
        public int Update()
        {
            String file = UploadAnh();
            object madanhmuc = ((DropDownList)page.FindControl("DropDownList1")).SelectedValue;
            object ten = ((TextBox)page.FindControl("ten")).Text;
            object id = ((TextBox)page.FindControl("masp")).Text;
            object dongia = ((TextBox)page.FindControl("dongia")).Text;
            Dictionary<String, Object> list = new Dictionary<string, object>();
            list.Add("@id", id);
            list.Add("@ten", ten);
            list.Add("@hinhanh", file);
            list.Add("@dongia", dongia);
            list.Add("@madm", madanhmuc);
            return class1.Sua(list);
        }

        public void Delete()
        {
            object ma = ((TextBox)page.FindControl("masp")).Text;
            Dictionary<String, Object> list = new Dictionary<string, object>();
            list.Add("@id", ma);
            class1.Xoa(list);
        }

        public int Them()
        {
            String file = UploadAnh();
            object madanhmuc = ((DropDownList)page.FindControl("DropDownList1")).SelectedValue;
            object ten = ((TextBox)page.FindControl("ten")).Text;
            object dongia = ((TextBox)page.FindControl("dongia")).Text;
            Dictionary<String, Object> list = new Dictionary<string, object>();
            list.Add("@ten", ten);
            list.Add("@hinhanh", file);
            list.Add("@dongia", dongia);
            list.Add("@madm", madanhmuc);
            return class1.Them(list);
        }
    }
}