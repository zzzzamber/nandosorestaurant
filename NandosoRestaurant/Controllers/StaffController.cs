using System.Web.Mvc;

namespace NandosoRestaurant.Controllers
{
    public class StaffController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Staff";

            return View();
        }
    }
}