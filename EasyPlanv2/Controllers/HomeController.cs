﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyPlanv2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Footer()
        {

            return View();
        }
        public ActionResult Mision()
        {

            return View();
        }
        public ActionResult Vision()
        {

            return View();
        }
        public ActionResult Objetives()
        {

            return View();
        }
        public ActionResult Projection()
        {
            return View();
        }
        public ActionResult Values()
        {

            return View();
        }
        public ActionResult AboutUS()
        {

            return View();
        }
    }
}