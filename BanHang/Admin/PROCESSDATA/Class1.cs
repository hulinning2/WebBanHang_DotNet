using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BanHang.Admin.CONT
{
    public class Class1
    {
        WebBanHangEntities db;
        BanHang.App_Code.Class1 xuly;
        ServiceReference1.ServiceClient ws;
        public Class1()
        {
            xuly = new BanHang.App_Code.Class1();
            ws = new ServiceReference1.ServiceClient();
            db = new WebBanHangEntities();
        }

        public DataTable getTableDanhMuc()
        {
            return xuly.getTable("SELECT * FROM DanhMucSanPham");
        }
        public DataTable getSanPham()
        {
            return xuly.getTable("SELECT * FROM DanhSachSanPham");

        }

        public List<DanhSachSanPham> gettableSanPham()
        {
            try
            {
                return db.DanhSachSanPham.ToList<DanhSachSanPham>();
            }
            catch (SqlException ex)
            {

            }
            return null;
        }

        public List<DanhMucSanPham> getDanhMuc()
        {
            try
            {
                return db.DanhMucSanPham.ToList<DanhMucSanPham>();
            }
            catch (SqlException ex)
            {

            }
            return null;
        }

        public int Them(Dictionary<String, Object> List)
        {
            SqlParameter[] pr = new SqlParameter[List.Count];
            for (int i = 0; i < List.Count; i++)
            {
                SqlParameter param;
                if (List.ElementAt(i).Value != null)
                {
                    param = new SqlParameter(List.ElementAt(i).Key, List.ElementAt(i).Value);
                }
                else
                {
                    param = new SqlParameter(List.ElementAt(i).Key, DBNull.Value);
                }
                pr[i] = param;
            }
            try
            {
                return ws.ExeCuteProcedurce("InsertProduct", List);
            }
            catch (SqlException ex)
            {
                return 0;
            }
        }

        public int Sua(Dictionary<String, Object> List)
        {
            SqlParameter[] pr = new SqlParameter[List.Count];
            for (int i = 0; i < List.Count; i++)
            {
                SqlParameter param;
                if (List.ElementAt(i).Value != null)
                {
                    param = new SqlParameter(List.ElementAt(i).Key, List.ElementAt(i).Value);
                }
                else
                {
                    param = new SqlParameter(List.ElementAt(i).Key, DBNull.Value);
                }
                pr[i] = param;
            }
            //           return xuly.ExeCute("UpdateProduct", pr);
            try
            {
                return ws.ExeCuteProcedurce("UpdateProduct", List);
            }
            catch (SqlException ex)
            {
                return 0;
            }
        }

        public int Xoa(Dictionary<String, Object> List)
        {
            SqlParameter[] pr = new SqlParameter[List.Count];
            for (int i = 0; i < List.Count; i++)
            {
                SqlParameter param;
                if (List.ElementAt(i).Value != null)
                {
                    param = new SqlParameter(List.ElementAt(i).Key, List.ElementAt(i).Value);
                }
                else
                {
                    param = new SqlParameter(List.ElementAt(i).Key, DBNull.Value);
                }
                pr[i] = param;
            }
            //            return xuly.ExeCute("DeleteProduct", pr);
            try
            {
                return ws.ExeCuteProcedurce("DeleteProduct", List);
            }
            catch (SqlException ex)
            {
                return 0;
            }
        }

        public int Delete(int id)
        {
            int k = 0;
            try
            {
                k = db.DeleteProduct(id);
                db.SaveChanges();
            }
            catch (SqlException ex)
            {
            }
            return k;
        }


    }

}
