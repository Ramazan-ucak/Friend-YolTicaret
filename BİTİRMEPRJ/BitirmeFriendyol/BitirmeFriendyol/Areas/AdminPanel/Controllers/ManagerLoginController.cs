using BitirmeFriendyol.Areas.AdminPanel.Model.ViewModel;
using BitirmeFriendyol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeFriendyol.Areas.AdminPanel.Controllers
{
    public class ManagerLoginController : Controller
    {
        DBModel db = new DBModel();
        // GET: AdminPanel/ManagerLogin
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AdminLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (db.Managers.Count(x=> x.Mail == model.Mail && x.Password == model.Password)>0)
                {
                    Manager m = db.Managers.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
                    Session["manager"] = m;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);

        }
    }
}