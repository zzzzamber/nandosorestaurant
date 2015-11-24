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
        [HttpGet]
        public ActionResult Index()
        {

            //  var firstname = Request.Form["firstname"];
            //   var lastname = Request.Form["lastname"];
            //  var feedback = Request.Form["feedback"];
            return View();
        }

        [HttpPost]
        public ActionResult Index(string firstname, string lastname, string feedback)
        {
            // return RedirectToAction("Reply", new { FirstName = firstname, LastName = lastname, Feedback = feedback });
            ViewBag.FirstName = firstname;
            ViewBag.LastName = lastname;
            ViewBag.Feedback = feedback;
            return View("Reply");
        }
   
    }
}