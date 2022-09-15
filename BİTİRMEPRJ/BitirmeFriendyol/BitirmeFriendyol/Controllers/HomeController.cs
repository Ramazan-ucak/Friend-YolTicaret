using BitirmeFriendyol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeFriendyol.Controllers
{
    public class HomeController : Controller
    {
        DBModel db = new DBModel();
        // GET: Home
        public ActionResult Index()
        {
            List<Product> ProductList = db.Products.Where(x => x.SellStatus == true).ToList();
            return View(ProductList);
        }
  
      
    }
}