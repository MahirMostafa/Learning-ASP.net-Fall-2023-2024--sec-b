using Company_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company_website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Home()
        {
            ViewBag.cname = "ABC SOFT";
            ViewBag.cemail = "ABC@gmail.com";
            ViewBag.Address = "Dhaka,Bangladesh";
            ViewBag.Desc = "A software companny";
            
            return View();
        }
        public ActionResult Project()
        {
            Project c = new Project();
            c.Name = "Hospital Management";
            c.Auther = "Deshi Teach";
            c.Email = "www.deshiteach@gmail.com";
            return View(c);
        }
        public ActionResult Team()
        {
            return View();
        }
        

    }
}