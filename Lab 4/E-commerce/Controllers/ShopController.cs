using E_commerce.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerce.Controllers
{
    public class ShopController : Controller
    {
        
        public ActionResult Index()
        {
            var db = new Lab_TaskEntities1();
            var data = db.Products.ToList();
            return View(data);
        }
    }
}