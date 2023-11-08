using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanhHang_MVC.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: TrangChu
        private WebBanHangEntities_1 db = new WebBanHangEntities_1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            DanhSachSanPham danhsachsanpham = db.DanhSachSanPham.Find(id);
            if (danhsachsanpham == null)
            {
                return HttpNotFound();
            }
            return View(danhsachsanpham);
        }
    }
}