using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Details()
        {
            Detail details = new Detail()
            {
                features1 = "helps students understand the concept of few essential topics at their own pace",
                features2 = "liberty to express themselves",
                features3 = "boost their self confidence by clarifying their doubts",
                features4 = "affordable, time convenient"
            };

            return View(details);
        }
    }
}