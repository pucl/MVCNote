using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class TourMVCController : Controller
    {
        // GET: TourMVC
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1A()
        {
            return View("Index");
        }

        public String Index1B()
        {
            return "I AM STRING";
        }
        public ActionResult Index1C()
        {
            return Redirect("http://www.yahoo.com.tw");
        }
        public ActionResult Index1D()
        {
            ViewData["A"] = "I AM VIEW DATRAA";
            ViewBag.A = "I AM VIEW B";
            TempData["C"] = "I AM VIEW C";
            return View();
        }
    }
}