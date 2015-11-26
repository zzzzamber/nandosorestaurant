using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using NandosoRestaurant.Models;

namespace NandosoRestaurant.Controllers
{
    public class MyFeedbackController : ApiController
    {
        private NandosoDBContext db = new NandosoDBContext();

        // GET
        public IQueryable<MyFeedback> GetFeedbacks()
        {
            return db.feedbacks;
        }

        // POST
        [ResponseType(typeof(MyFeedback))]
        public IHttpActionResult AddFeedback(MyFeedback myFeedback)
        {
            db.feedbacks.Add(myFeedback);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = myFeedback.Id }, myFeedback);
        }
    }
}