using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using LapbaseEntityFramework.DemoRepositories;

namespace LapbaseAPI.Controllers.DemoControllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class PatientController : ApiController
    {
       
        private readonly IPatientDemographicRepository patientDemographicRepository = new PatientDemographicRepository();
        [HttpGet]
        public IHttpActionResult GetPatient(long id, long organizationCode)
        {
            var patient = patientDemographicRepository.GetPatient(id, organizationCode);

            return Ok(patient);
        }
    }
}
