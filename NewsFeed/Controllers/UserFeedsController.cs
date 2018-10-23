using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MyFeeds.Models;
using NewsFeed.Models;

namespace NewsFeed.Controllers
{
    public class UserFeedsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Suscribe([Bind(Include = "Id,Origin")] Source source)
        {
            var userFeed = new UserFeed
            {
                SourceId = source.Id,
                UserId = User.Identity.GetUserId()

            };

            if (ModelState.IsValid)
            {
                db.UserFeeds.Add(userFeed);
                db.SaveChanges();
                return RedirectToAction("Index", "Sources");
            }
            return View("Error");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
