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
using LapbaseEntityFramework.Repositories;
using LapbaseEntityFramework.ViewModel;

namespace LapbaseAPI.Controllers
{
    public class WeightController : ApiController
    {
        private readonly IWeightRepository weightRepository = new WeightRepository();

        // GET: api/Weight
        public IHttpActionResult GetWeights(long PatientID, long OrganizationCode)
        {
            var weights = weightRepository.GetWeights(PatientID, OrganizationCode);
            return Ok(weights);
        }

        [HttpGet]
        [ResponseType(typeof(Weight))]
        public IHttpActionResult GetLatestWeight(long PatientID, long OrganizationCode)
        {
            Weight weight = weightRepository.GetLatestWeight(PatientID,OrganizationCode);
            if (weight == null)
            {
                return NotFound();
            }

            return Ok(weight);
        }

        // GET: api/Weight/5
        [ResponseType(typeof(Weight))]
        public IHttpActionResult GetWeight(long id)
        {
            Weight weight = weightRepository.GetWeightByID(id);
            if (weight == null)
            {
                return NotFound();
            }

            return Ok(weight);
        }

        [HttpGet]
        [ResponseType(typeof(WeightViewModel))]
        public IHttpActionResult GetWeightM(long PatientID, long OrganizationCode)
        {
            var weight = weightRepository.GetWeightM(PatientID, OrganizationCode);
           

            return Ok(weight);
        }

        // PUT: api/Weight/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWeight(long id, Weight weight)
        {
            if (weight.ID != id)
            {
                return NotFound();

            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    weightRepository.UpdateWeight(weight);
                    weightRepository.Save();
                    return Ok(weight);
                }

            }
        }

        // POST: api/Weight
        [ResponseType(typeof(Weight))]
        public IHttpActionResult PostWeight(Weight weight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            weightRepository.InsertWeight(weight);


            return Ok(weight);
        }

    }
}