using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestarauntRater1.Controllers
{
    public class RestarauntController : Controller
    {
        // GET: Restaraunt
        public ActionResult Index()
        {
            return View();
        }
    }
}