using System.Web.Mvc;
using NandosoRestaurant.Models;

namespace NandosoRestaurant.Controllers
{
    public class FeedbackController : Controller
    {
        private NandosoDBContext db = new NandosoDBContext();

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
        public ActionResult Index(string firstname, string lastname, string email, string feedback)
        {
            // return RedirectToAction("Reply", new { FirstName = firstname, LastName = lastname, Feedback = feedback });
            ViewBag.FirstName = firstname;
            ViewBag.LastName = lastname;
            ViewBag.Email = email;
            ViewBag.Feedback = feedback;

            var myFeedback = new MyFeedback
            {
                Email = email,
                Feedback = feedback,
                FirstName = firstname,
                LastName = lastname
            };

            db.feedbacks.Add(myFeedback);
            db.SaveChanges();

            return View("Reply");
        }
    }
}