using AutoMapper;
using E_commerce.DTO;
using E_commerce.DTOS;
using E_commerce.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace E_commerce.Controllers
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

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost] 
        public ActionResult Signup(UserSignUpDTO us)
        {
            if(ModelState.IsValid)
            {
                var db = new Lab_TaskEntities1();
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<UserSignUpDTO, User>();
                });
                var mapper = new Mapper(config);
               var data3 =  mapper.Map<User>(us);
                db.Users.Add(Convert(us));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
             return View();
            }

        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginDTO user)
        {
            if (ModelState.IsValid)
            {
                var db = new Lab_TaskEntities1();
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<UserLoginDTO, User>();
                });
                var mapper = new Mapper(config);
                var dbUser = db.Users.FirstOrDefault(u => u.Email == user.Email);
                if (dbUser != null)
                {
                    if (dbUser.Password == user.Password) 
                    {
                       
                       
                        return RedirectToAction("Index");
                    }
                    else
                    {
                       
                        ModelState.AddModelError("", "The password provided is incorrect.");
                    }
                }
                else
                {
                    
                    ModelState.AddModelError("", "The user with provided email does not exist.");
                }
            }

            
            return View();
        }


        UserSignUpDTO Convert(User u )
        {
            return new UserSignUpDTO()
            {
             Name = u.Name, 
             Email = u.Email,
             Phone_Number = u.Phone_Number,
             Password = u.Password,
             Address = u.Address,

            };
        }

        User Convert(UserSignUpDTO u)
        {
            return new User()
            {
                Name = u.Name,
                Email = u.Email,
                Phone_Number = u.Phone_Number,
                Password = u.Password,
                Address = u.Address,

            };
        }


        //UserLoginDTO Convert(User u)
        //{
        //    return new UserLoginDTO()
        //    {
        //        Name = u.Name,
        //        Email = u.Email,
        //        Phone_Number = u.Phone_Number,
        //        Password = u.Password,
        //        Address = u.Address,

        //    };
        //}

        //User Convert(UserLoginDTO u)
        //{
        //    return new User()
        //    {
        //        Name = u.Name,
        //        Email = u.Email,
        //        Phone_Number = u.Phone_Number,
        //        Password = u.Password,
        //        Address = u.Address,

        //    };
        //}

    }
    
}