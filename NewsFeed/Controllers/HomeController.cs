using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsFeed.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var user = User.Identity.GetUserId();
            if (user != null) {
                return RedirectToAction("Index", "Sources");
            }
            return View();
        }
        
        public ActionResult NoLogged()
        {
            return View();
        }

        public ActionResult Register()
        {
            return RedirectToAction("Register", "Account");

        }

        public ActionResult LogIn()
        {
            return RedirectToAction("Login", "Account");

        }
    }
}