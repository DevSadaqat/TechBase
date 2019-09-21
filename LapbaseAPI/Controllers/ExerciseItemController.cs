using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using LapbaseBOL;
using LapbaseEntityFramework.Repositories;

namespace LapbaseAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ExerciseItemController : ApiController
    {
        private readonly IExerciseItemRepository exerciseItemRepository = new ExerciseItemRepository();

        [HttpGet]
        // GET: api/GetExercises
        public IHttpActionResult GetExercises()
        {
            var exercises = exerciseItemRepository.GetExercises();
            return Ok(exercises);
        }

        [HttpGet]
        // GET: api/GetIntenseExercises
        public IHttpActionResult GetExerciseIntense()
        {
            var exercises = exerciseItemRepository.GetIntenseExercises();
            return Ok(exercises);
        }
        [HttpGet]
        // GET: api/GetILightExercises
        public IHttpActionResult GetExerciseLight()
        {
            var exercises = exerciseItemRepository.GetLightExercises();
            return Ok(exercises);
        }
        [HttpGet]
        // GET: api/GetModerateExercises
        public IHttpActionResult GetExerciseModerate()
        {
            var exercises = exerciseItemRepository.GetModerateExercises();
            return Ok(exercises);
        }

        // GET: api/exerciseitem?name=walking
        [ResponseType(typeof(ExerciseItem))]
        public IHttpActionResult GetExerciseItem(string name)
        {
            var exercise = exerciseItemRepository.GetExerciseItem(name);
            if (exercise == null)
            {
                return NotFound();
            }

            return Ok(exercise);
        }
    }
}
