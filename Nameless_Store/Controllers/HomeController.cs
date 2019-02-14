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

        public ActionResult Volkswagen_cars()
        {
            return View();
        }

        public ActionResult General_Motors_cars()
        {
            return View();
        }

        public ActionResult Gol_1()
        {
            return View();
        }

        public ActionResult Thanks_for_your_Purchase()
        {
            return View();
        }

        public ActionResult Passat_LSE()
        {
            return View();
        }

        public ActionResult Gol_GTS_92()
        {
            return View();
        }

        public ActionResult Golf_GTI()
        {
            return View();
        }

        public ActionResult Jetta_TSI()
        {
            return View();
        }

        public ActionResult Passat_VR6()
        {
            return View();
        }

        public ActionResult Chevette_DL()
        {
            return View();
        }

        public ActionResult Chevy_500()
        {
            return View();
        }

        public ActionResult Omega_Suprema()
        {
            return View();
        }
    }
}