using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NandosoRestaurant.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult Index()
        {
            var request = Request.Form;
            var firstname = Request.Form["firstname"];
            var lastname = Request.Form["lastname"];
            var feedback = Request.Form["feedback"];
            return View();
        }
    }
}