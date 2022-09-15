﻿using BitirmeFriendyol.Areas.AdminPanel.Filters;
using BitirmeFriendyol.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeFriendyol.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class ProductController : Controller
    {
        DBModel db = new DBModel();
        // GET: AdminPanel/Product
        public ActionResult Index()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Category_ID = new SelectList(db.Categories.Where(x => x.Status == true), "ID", "Name");
            ViewBag.Brand_ID = new SelectList(db.Brands.Where(x=> x.Status == true), "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product model, HttpPostedFileBase resim)
        {
            if (ModelState.IsValid)
            {
                if (resim != null)
                {
                    FileInfo fi = new FileInfo(resim.FileName);
                    string imagename = Guid.NewGuid().ToString() + fi.Extension;
                    model.CoverImage = imagename;
                    resim.SaveAs(Server.MapPath("~/Images/ProductImages/"+imagename));
                }
                else
                {
                    model.CoverImage = "none.jpg";
                }
                model.CreationDay = DateTime.Now;
                db.Products.Add(model);
                db.SaveChanges();
                return RedirectToAction("AddImage", "Product", new { id = model.ID });
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                Product p = db.Products.Find(id);
                ViewBag.Category_ID = new SelectList(db.Categories.Where(x => x.Status == true), "ID", "Name", p.Category_ID);
                ViewBag.Brand_ID = new SelectList(db.Brands.Where(x => x.Status == true), "ID", "Name", p.Brand_ID);
                return View(p);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Product p, HttpPostedFileBase resim)
        {
            if (ModelState.IsValid)
            {
                if (resim != null)
                {
                    FileInfo fi = new FileInfo(resim.FileName);
                    string imagename = Guid.NewGuid().ToString() + fi.Extension;
                    p.CoverImage = imagename;
                    resim.SaveAs(Server.MapPath("~/Images/ProductImages/" + imagename));
                }
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }
        [HttpGet]
        public ActionResult AddImage(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.product = db.Products.Find(id);
            return View();
        }
        [HttpPost]
        public ActionResult AddImage(int? id, HttpPostedFileBase resim)
        {
            if (resim != null)
            {
                FileInfo fi = new FileInfo(resim.FileName);
                string imagename = Guid.NewGuid().ToString() + fi.Extension;
                ProductImage pi = new ProductImage();
                pi.Product_ID = Convert.ToInt32(id);
                pi.ImagePath = imagename;
                resim.SaveAs(Server.MapPath("~/Images/ProductImages/" + imagename));
                db.ProductImages.Add(pi);
                db.SaveChanges();
            }
            return RedirectToAction("AddImage", "Product", new { id = id });
        }
        public ActionResult DeleteProduct(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Product p = db.Products.Find(id);
            p.SellStatus = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteImage(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ProductImage pii = db.ProductImages.Find(id);
            //PI.Status = false;//Soft Delete
            db.ProductImages.Remove(pii);//Hard Delete
            db.SaveChanges();
            return RedirectToAction("AddImage", "Product");
        }

    }


}
