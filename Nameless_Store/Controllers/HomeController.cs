﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nameless_Store.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Let's Talk about Nameless Store - Cars And Autoparts.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact the site owner.";

            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Brands()
        {
            return View();
        }
    }
}