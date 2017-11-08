using FirstASPwebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstASPwebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var factory = new ShopFactory();
            var products = factory.Products.ToList();
            return View(products);
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

        public ActionResult Details(int id)
        {
            var factory = new ShopFactory();
            var found = factory.Products.Where(p => p.ID == id).FirstOrDefault();
            return View(found);
        }
    }
}