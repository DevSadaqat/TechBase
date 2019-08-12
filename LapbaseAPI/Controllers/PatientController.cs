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
using LapbaseEntityFramework.Repositories;
using LapbaseBOL;
namespace LapbaseAPI.Controllers
{
    public class PatientController : ApiController
    {
        private readonly IPatientRepository patientRepository = new PatientRepository();


        // GET: api/Patient
        public IHttpActionResult GetPatient()
        {
            var patients = patientRepository.GetPatients();
            return Ok(patients);
        }


        // GET: api/Patient/5
        // [ResponseType(typeof(Patient))]
        public IHttpActionResult GetPatient(long id, long organizationCode)
        {
            var patient = patientRepository.GetPatient(id, organizationCode);
            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }
        // PUT: api/Patient/5
        [HttpPut]
        public IHttpActionResult PutPatient(long id, long organizationCode, Patient patient)
        {

            if (patient.ID != id || patient.OrganizationCode != organizationCode)
            {
                return NotFound();
            }

            else
            {
                if (ModelState.IsValid)
                {
                    patientRepository.UpdatePatient(patient);
                    patientRepository.Save();
                    return Ok(patient);

                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
        }
    }
}