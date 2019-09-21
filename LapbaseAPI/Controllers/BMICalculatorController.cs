using LapbaseEntityFramework.Repositories;
using LapbaseEntityFramework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LapbaseAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class BMICalculatorController : ApiController
    {
        private readonly IBMICalculatorRepository bmirepository = new BMICalculatorRepository();

        [HttpGet]
        public IHttpActionResult CalculateBMI(long PatientID, long OrganizationCode, decimal weight)
        {
            BMICalculatorViewModel bmiVM = bmirepository.calculateBMI(PatientID, OrganizationCode, weight);
            return Ok(bmiVM);
        }
    }
}
