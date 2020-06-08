using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTraSua_16.Dao;

namespace WebTraSua_16.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult Index()
        {
            var model = new SanPhamDao().Menu();
            return View(model);
        }
        public ActionResult ListSanPham()
        {
            var model = new SanPhamDao().ListSP(3);
            return PartialView(model);
        }

        public ActionResult SanPhamOD(long MaSanPham)
        {
            var spOD = new SanPhamDao().Detail(MaSanPham);
            ViewBag.SPLienQuan = new SanPhamDao().SanPhamLQ(MaSanPham);
            return View(spOD);
        }
    }
}