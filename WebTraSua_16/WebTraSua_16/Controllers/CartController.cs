using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTraSua_16.Dao;
using WebTraSua_16.Models;

namespace WebTraSua_16.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
       
        private const string CartSession = "CartSession";

        public ActionResult Index()
        {
            var cart = (Cart)Session[CartSession];

            var list = new List<CartItem>();

            if (cart != null)
            {
                list = cart.Lines.ToList();
                ViewBag.TongTien = cart.ComputeTotalValue();
            }

            return View(list);
        }



        public ActionResult AddItem(long Id, string returnURL)
        {

            var product = new SanPhamDao().FindEntity(Id);

            var cart = (Cart)Session[CartSession];

            var duong = Request.Form["duong"];
            Console.WriteLine(duong);

            if (cart != null)
            {
                cart.AddItem(product, 1,duong);
                //Gán vào session
                Session[CartSession] = cart;
            }
            else
            {
                //tạo mới đối tượng cart item
                cart = new Cart();
                cart.AddItem(product, 1,duong);
                //Gán vào session
                Session[CartSession] = cart;
            }

            if (string.IsNullOrEmpty(returnURL))
            {
                return RedirectToAction("Index");
            }

            return Redirect(returnURL);

        }
    }
}