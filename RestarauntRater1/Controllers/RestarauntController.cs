using RestarauntRater1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestarauntRater1.Controllers
{
    public class RestarauntController : Controller
    {
        private RestarauntDBContext db = new RestarauntDBContext();
        // GET: Restaraunt
        public ActionResult Index()
        {
            return View(db.Restaraunts.ToList());
        }

        // GET: Restaraunt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST : Restaraunt/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaraunt restaraunt)
        {
            if (ModelState.IsValid)
            {
                db.Restaraunts.Add(restaraunt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaraunt);
        }
    }
}