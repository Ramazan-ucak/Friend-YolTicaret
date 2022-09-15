using BitirmeFriendyol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeFriendyol.Controllers
{
    public class FavoriteController : Controller
    {
        DBModel db = new DBModel();
        // GET: Favorite
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                int id = ((User)Session["user"]).ID;
                return View(db.Favorites.Where(x => x.User_ID == id).ToList());
            }
            return RedirectToAction("Login", "User");
        }
        //public ActionResult AddFavorites(int? id)
        //{
        //    if (id != null)
        //    {
        //        if (Session["user"] != null)
        //        {
        //            Favorite fv = new Favorite();
        //            fv.User_ID = ((User)Session["user"]).ID;
        //            fv.Product_ID = Convert.ToInt32(id);
        //            fv.Quantity = 1;
        //            fv.CreationDate = DateTime.Now;
        //            db.Favorites.Add(fv);
        //            db.SaveChanges();
        //        }
        //        else
        //        {
        //            return RedirectToAction("Login", "User");
        //        }

        //    }
        //    return RedirectToAction("Index", "Home");



        //}

        public ActionResult AddFavorites(int? id, int? adet)
        {

            if (id != null)
            {
                if (Session["user"] != null)
                {
                    Favorite ucc = db.Favorites.FirstOrDefault(x => x.Product_ID == id);

                    if (ucc == null)
                    {
                        Favorite uc = new Favorite();
                        uc.User_ID = ((User)Session["user"]).ID;
                        uc.Product_ID = Convert.ToInt32(id);
                        uc.Quantity = adet ?? 1;
                        uc.CreationDate = DateTime.Now;
                        db.Favorites.Add(uc);
                        db.SaveChanges();
                    }
                    else
                    {
                        ucc.Quantity = ucc.Quantity + (adet ?? 1);
                        db.SaveChanges();
                    }

                }
                else
                {
                    return RedirectToAction("Login", "User");
                }

            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult increase(int id)
        {
            Favorite fv = db.Favorites.Find(id);
            fv.Quantity += 1;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult decrease(int id)
        {
            Favorite fv = db.Favorites.Find(id);
            if (fv.Quantity != 0)
            {
                fv.Quantity -= 1;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteFavorite(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Favorite fv = db.Favorites.Find(id);

            db.Favorites.Remove(fv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
     
    }
}