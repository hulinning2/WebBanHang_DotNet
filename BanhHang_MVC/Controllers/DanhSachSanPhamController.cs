using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BanhHang_MVC;

namespace BanhHang_MVC.Controllers
{
    public class DanhSachSanPhamController : Controller
    {
        private WebBanHangEntities_1 db = new WebBanHangEntities_1();

        // GET: DanhSachSanPham
        public ActionResult Index()
        {
            return View(db.DanhSachSanPham.ToList());
        }

        // GET: DanhSachSanPham/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhSachSanPham danhSachSanPham = db.DanhSachSanPham.Find(id);
            if (danhSachSanPham == null)
            {
                return HttpNotFound();
            }
            return View(danhSachSanPham);
        }

        // GET: DanhSachSanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DanhSachSanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ten,hinhanh,dongia,madm")] DanhSachSanPham danhSachSanPham)
        {
            if (ModelState.IsValid)
            {
                db.DanhSachSanPham.Add(danhSachSanPham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhSachSanPham);
        }

        // GET: DanhSachSanPham/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhSachSanPham danhSachSanPham = db.DanhSachSanPham.Find(id);
            if (danhSachSanPham == null)
            {
                return HttpNotFound();
            }
            return View(danhSachSanPham);
        }

        // POST: DanhSachSanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ten,hinhanh,dongia,madm")] DanhSachSanPham danhSachSanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhSachSanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhSachSanPham);
        }

        // GET: DanhSachSanPham/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhSachSanPham danhSachSanPham = db.DanhSachSanPham.Find(id);
            if (danhSachSanPham == null)
            {
                return HttpNotFound();
            }
            return View(danhSachSanPham);
        }

        // POST: DanhSachSanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DanhSachSanPham danhSachSanPham = db.DanhSachSanPham.Find(id);
            db.DanhSachSanPham.Remove(danhSachSanPham);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
