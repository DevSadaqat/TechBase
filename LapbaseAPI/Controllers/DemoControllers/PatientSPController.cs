using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LapbaseEntityFramework.DemoRepositories;

namespace LapbaseAPI.Controllers.DemoControllers
{
    public class PatientSPController : ApiController
    {
        private readonly IPatientDemographicRepository patientDemographicRepository = new PatientDemographicRepository();
        [HttpGet]
        public IHttpActionResult GetPatientSP(long id, long organizationCode)
        {
            var patient = patientDemographicRepository.GetPatient(id, organizationCode);

            return Ok(patient);
        }
    }
}
