using BitirmeFriendyol.Areas.AdminPanel.Filters;
using BitirmeFriendyol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeFriendyol.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class BrandController : Controller
    {
        DBModel db = new DBModel();
        // GET: AdminPanel/Brand
        public ActionResult Index()
        {
            List<Brand> brands = db.Brands.ToList();
            return View(brands);
        }
        [HttpGet]
        public ActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBrand(Brand model)
        {
            if (ModelState.IsValid)
            {
                db.Brands.Add(model);
                db.SaveChanges();
                return  RedirectToAction("Index");
            }
            return View(model); 
        }
        [HttpGet]
        public ActionResult EditBrand(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Brand brand = db.Brands.Find(id);
            return View(brand); 
        }
        [HttpPost]
        public ActionResult EditBrand(Brand model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult DeleteBrand(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Brand b = db.Brands.Find(id);
            b.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}