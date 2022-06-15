using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShoppingCart;

namespace ShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        ShoppingCartEntities db = new ShoppingCartEntities();

        public ActionResult Index()
        {
            var products = db.Product.Include(p => p.Category).Include(p => p.Mark).Include(p => p.Supplier)
                .Where(x=> x.Enabled);

            return View(products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}