using BitirmeFriendyol.Models;
using BitirmeFriendyol.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeFriendyol.Controllers
{
    public class UserController : Controller
    {
        DBModel db = new DBModel();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User u = db.Users.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
                if (u != null)
                {
                    Session["user"] = u;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult SingUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SingUp(User user)
        {
            if (ModelState.IsValid)
            {

                user.CreationDate = DateTime.Now;
                user.Status = true;
                db.Users.Add(user);

                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);
        }
        public ActionResult LogOut()
        {
            Session.Remove("user");
            return RedirectToAction("Index", "Home");
        }

        public ActionResult UserDetails()
        {
            if (Session["user"] != null)
            {
                int id = ((User)Session["user"]).ID;
                return View(db.Users.Where(x => x.ID == id).ToList());
            }
            else
            {
                return View("Login", "Home");
            }
        }
        [HttpGet]
        public ActionResult EditUser(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("UserDetails");
            }
            User u = db.Users.Find(id);
            return View(u);
        }
        [HttpPost]
        public ActionResult EditUser(User model)
        {

            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                model.CreationDate = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }


            return View(model);
        }

    }
}