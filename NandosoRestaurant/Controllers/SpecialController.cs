﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NandosoRestaurant.Controllers
{
    public class SpecialController : Controller
    {
        // GET: Special
        public ActionResult Index()
        {
            return View();
        }
        //Special/Order
        public ActionResult Order()
        {
            return View();
        }
    }
}