using BitirmeFriendyol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Xml.Linq;

namespace BitirmeFriendyol.Areas.AdminPanel.Controllers
{
    public class XMLController : Controller
    {
        DBModel db = new DBModel();
        // GET: AdminPanel/XML
       
        public ActionResult Index()
        {

            //XDocument xDoc = XDocument.Load("C:/Urunler/Urunler.xml");
            //XElement rootElement = xDoc.Root;
            //foreach (XElement item in rootElement.Elements())
            //{

            //    ViewBag.ItemID = item.Attribute("id").Value;
            //    ViewBag.ItemName = item.Element("name").Value;
            //    ViewBag.ItemDes = item.Element("description").Value;
            //    ViewBag.ItemStock = item.Element("stock").Value;
            //    ViewBag.ItemPrice = item.Element("price").Value;
            //    ViewBag.ItemImage = item.Element("image").Value;
            //    ViewBag.ItemCreation = DateTime.Now.ToString();
            //    ViewBag.ItemStatus = item.Element("status").Value;
            //    ViewBag.ItemCategory = item.Element("category").Value;
            //    ViewBag.ItemBrand = item.Element("brand").Value;
            //    ViewBag.Adet = 10;
            //    ViewBag.ulkeler.Add(item);

            //}




            //ViewBag.Ulkeler = new List<XElement>();
           
            XDocument xDoc = XDocument.Load("C:/Urunlerim/XmlUrun.xml");
            XElement rootElement = xDoc.Root;
            ViewBag.ulkeler = new List<XElement>();
            //ViewBag.ItemID = ""; ViewBag.ItemName = ""; ViewBag.ItemDes = ""; ViewBag.ItemStock = ""; ViewBag.ItemPrice = ""; ViewBag.ItemImage = ""; ViewBag.ItemCreation = ""; ViewBag.ItemCategory = ""; ViewBag.ItemBrand = "";

            foreach (XElement item in rootElement.Elements())
            {

                ViewBag.ItemID = item.Attribute("id").Value;
                ViewBag.ItemName = item.Element("name").Value;
                ViewBag.ItemDes = item.Element("description").Value;
                ViewBag.ItemStock = item.Element("stock").Value;
                ViewBag.ItemPrice = item.Element("price").Value;
                ViewBag.ItemImage = item.Element("image").Value;
                ViewBag.ItemCreation = DateTime.Now.ToString();
                //ViewBag.ItemStatus = item.Element("status").Value;
                ViewBag.ItemCategory = item.Element("category").Value;
                ViewBag.ItemBrand = item.Element("brand").Value;
                ViewBag.ulkeler.Add(item);
            }
            return View();
        }
}
}