using BitirmeFriendyol.Areas.AdminPanel.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BitirmeFriendyol.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class HomeController : Controller
    {
        // GET: AdminPanel/Home
        public ActionResult Index()
        {
            return View();
        }
   
     
    }
}