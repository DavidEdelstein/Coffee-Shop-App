using CoffeeShopApp.DALdata;
using CoffeeShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {
        private CoffeeShopContext db = new CoffeeShopContext();

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(NewUser newUser )
        {
            if (ModelState.IsValid)
            {
                db.NewUsers.Add(newUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddUser", newUser);
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
    }
}