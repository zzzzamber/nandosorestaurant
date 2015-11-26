using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using NandosoRestaurant.Models;

namespace NandosoRestaurant.Controllers
{
    public class MySpecialsController : ApiController
    {
        private NandosoDBContext db = new NandosoDBContext();

        // GET: api/MySpecials
        public IQueryable<MySpecial> Getspecials()
        {
            return db.specials;
        }

        // GET: api/MySpecials/5
        [ResponseType(typeof(MySpecial))]
        public IHttpActionResult GetMySpecial(int id)
        {
            MySpecial mySpecial = db.specials.Find(id);
            if (mySpecial == null)
            {
                return NotFound();
            }

            return Ok(mySpecial);
        }

        // PUT: api/MySpecials/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMySpecial(int id, MySpecial mySpecial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mySpecial.Id)
            {
                return BadRequest();
            }

            db.Entry(mySpecial).State = System.Data.Entity.EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MySpecialExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/MySpecials
        [ResponseType(typeof(MySpecial))]
        public IHttpActionResult PostMySpecial(MySpecial mySpecial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.specials.Add(mySpecial);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mySpecial.Id }, mySpecial);
        }

        // DELETE: api/MySpecials/5
        [ResponseType(typeof(MySpecial))]
        public IHttpActionResult DeleteMySpecial(int id)
        {
            MySpecial mySpecial = db.specials.Find(id);
            if (mySpecial == null)
            {
                return NotFound();
            }

            db.specials.Remove(mySpecial);
            db.SaveChanges();

            return Ok(mySpecial);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MySpecialExists(int id)
        {
            return db.specials.Count(e => e.Id == id) > 0;
        }
    }
}