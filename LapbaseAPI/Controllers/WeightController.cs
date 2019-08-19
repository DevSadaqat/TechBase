using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LapbaseBOL;
using LapbaseEntityFramework;

namespace LapbaseAPI.Controllers
{
    public class WeightController : ApiController
    {
        private LapbaseContext db = new LapbaseContext();

        // GET: api/Weight
        public IQueryable<Weight> GetWeights()
        {
            return db.Weights;
        }

        // GET: api/Weight/5
        [ResponseType(typeof(Weight))]
        public IHttpActionResult GetWeight(long id)
        {
            Weight weight = db.Weights.Find(id);
            if (weight == null)
            {
                return NotFound();
            }

            return Ok(weight);
        }

        // PUT: api/Weight/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWeight(long id, Weight weight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != weight.ID)
            {
                return BadRequest();
            }

            db.Entry(weight).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeightExists(id))
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

        // POST: api/Weight
        [ResponseType(typeof(Weight))]
        public IHttpActionResult PostWeight(Weight weight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Weights.Add(weight);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = weight.ID }, weight);
        }

        // DELETE: api/Weight/5
        [ResponseType(typeof(Weight))]
        public IHttpActionResult DeleteWeight(long id)
        {
            Weight weight = db.Weights.Find(id);
            if (weight == null)
            {
                return NotFound();
            }

            db.Weights.Remove(weight);
            db.SaveChanges();

            return Ok(weight);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WeightExists(long id)
        {
            return db.Weights.Count(e => e.ID == id) > 0;
        }
    }
}