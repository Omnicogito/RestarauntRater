using RestarauntRater1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        // POST: Restaraunt/Create
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

        //GET: Restaraunt/Delete/id
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaraunt restaraunt = db.Restaraunts.Find(id);
            if(restaraunt == null)
            {
                return HttpNotFound();
            }
            return View(restaraunt);
        }


        //POST: Restaraunt/Delete/id
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaraunt restaraunt = db.Restaraunts.Find(id);
            db.Restaraunts.Remove(restaraunt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}