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
using EF;

namespace LapbaseAPI.Controllers
{
    public class PatientController : ApiController
    {
        private Lapbase db = new Lapbase();

        // GET: api/Patient
        public IHttpActionResult GetPatient()
        {
            var patients = db.Patients.ToList();
            return Ok(patients);
        }
      

        // GET: api/Patient/5
        [ResponseType(typeof(Patient))]
        public IHttpActionResult GetPatient(long id, long organizationCode)
        {
            Patient patient = db.Patients.Find(id, organizationCode);
            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }

        // PUT: api/Patient/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPatient(long id, Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patient.ID)
            {
                return BadRequest();
            }

            db.Entry(patient).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(id))
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

        // POST: api/Patient
        [ResponseType(typeof(Patient))]
        public IHttpActionResult PostPatient(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Patients.Add(patient);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PatientExists(patient.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = patient.ID }, patient);
        }

        // DELETE: api/Patient/5
        [ResponseType(typeof(Patient))]
        public IHttpActionResult DeletePatient(long id)
        {
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return NotFound();
            }

            db.Patients.Remove(patient);
            db.SaveChanges();

            return Ok(patient);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PatientExists(long id)
        {
            return db.Patients.Count(e => e.ID == id) > 0;
        }
    }
}