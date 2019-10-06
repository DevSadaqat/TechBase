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
    public class EWLController : ApiController
    {
        private readonly IEWLRepository ewlRepository = new EWLRepository();
        [HttpGet]
        public IHttpActionResult GetEWLData(long id, long organizationCode)
        {
            var ewlData = ewlRepository.GetEWLData(id, organizationCode);

            return Ok(ewlData);
        }
    }
}
