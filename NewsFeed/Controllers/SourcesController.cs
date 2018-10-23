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
    public class SourcesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Sources
        public ActionResult Index()
        {
            
            var sources = db.Sources.Where(item => !db.UserFeeds.Any(item2 => item2.SourceId == item.Id)).ToList();
            return View(sources);
        }
        public ActionResult Search(string searchString)
        {

            var sources = db.Sources.Where(item => item.Origin.Contains(searchString) && !db.UserFeeds.Any(item2 => item2.SourceId == item.Id)).ToList();
            return View("Index", sources);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Origin")] Source source)
        {
            if (ModelState.IsValid)
            {
                db.Sources.Add(source);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(source);
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
