﻿using System.Web.Mvc;

namespace NandosoRestaurant.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

    
        
    }
}
