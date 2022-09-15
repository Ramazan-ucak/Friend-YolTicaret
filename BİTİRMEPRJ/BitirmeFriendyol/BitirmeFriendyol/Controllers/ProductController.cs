using BitirmeFriendyol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeFriendyol.Controllers
{
    public class ProductController : Controller
    {
        DBModel db = new DBModel();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Product p = db.Products.Find(id);
            return View(p);
        }
    }
}