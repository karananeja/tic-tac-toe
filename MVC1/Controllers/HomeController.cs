using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = new List<string>()
            {
                "helps students understand the concept of few essential topics at their own pace",
                "liberty to express themselves",
                "boost their self confidence by clarifying their doubts",
                "affordable, time convenient"
            };
            ViewBag.Title = "About Karan Tuitions";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "The Contact details are provied below for further communication";

            return View();
        }
        [HttpGet]
        public ActionResult Business()
        {
            return View();
        }
    }
}