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
    public class ContentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var user = User.Identity.GetUserId();
            if (user == null)
            {
                return RedirectToAction("NoLogged", "Home");

            }

            return View(db.Contents.ToList());
        }

        public ActionResult MyFeed()
        {
            var feeds = db.Contents.Where(item => db.UserFeeds.Any(item2 => item2.SourceId == item.SourceId)).ToList();
            
            return View("Index", feeds);
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
