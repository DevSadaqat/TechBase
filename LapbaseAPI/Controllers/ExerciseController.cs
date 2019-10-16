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
    public class ExerciseController : ApiController
    {
        private readonly IExerciseRepository exerciseRepository = new ExerciseRepository();

        // GET: api/Exercise
        [HttpGet]
        public IHttpActionResult GetExercises(long PatientID, long OrganizationCode)
        {
            var exercises = exerciseRepository.GetExercises(PatientID, OrganizationCode);
            return Ok(exercises);
        }

        [HttpGet]
        public IHttpActionResult GetRecentExercises(long PatientID, long OrganizationCode)
        {
            var exercises = exerciseRepository.GetRecentExercises(PatientID, OrganizationCode);
            return Ok(exercises);
        }

        // GET: api/Exercise/5
        [HttpGet]
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult GetExercise(long id)
        {
            var exercise = exerciseRepository.GetExerciseByID(id);
            if (exercise == null)
            {
                return NotFound();
            }

            return Ok(exercise);
        }

        [HttpGet]
        public IHttpActionResult GetCaloriesBurnt(long PatientID, long OrganizationCode)
        {
            var exercises = exerciseRepository.GetCaloriesBurnt(PatientID, OrganizationCode);
            return Ok(exercises);
        }

        [HttpGet]
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult FilterLight(long id, long OrganizationCode)
        {
            var exercise = exerciseRepository.FilterLight(id, OrganizationCode);
            if (exercise == null)
            {
                return NotFound();
            }

            return Ok(exercise);
        }

        [HttpGet]
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult FilterModerate(long id, long OrganizationCode)
        {
            var exercise = exerciseRepository.FilterModerate(id, OrganizationCode);
            if (exercise == null)
            {
                return NotFound();
            }

            return Ok(exercise);
        }

      
        [HttpGet]
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult FilterIntense(long id, long OrganizationCode)
        {
            var exercise = exerciseRepository.FilterIntense(id, OrganizationCode);
            if (exercise == null)
            {
                return NotFound();
            }

            return Ok(exercise);
        }

        [HttpGet]
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult FilterExerciseName(long id, long OrganizationCode, string exerciseName)
        {
            var exercise = exerciseRepository.FilterExerciseName(id, OrganizationCode, exerciseName);
            if (exercise == null)
            {
                return NotFound();
            }

            return Ok(exercise);
        }

        // PUT: api/Exercise/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutExercise(long id, Exercise exercise)
        {
            if (exercise.ID != id)
            {
                return NotFound();
            }

            else
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                else
                {
                    exerciseRepository.UpdateExercise(exercise);
                    exerciseRepository.Save();
                    return Ok(exercise);
                }
            }
                                             
        }

        // POST: api/Exercise
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult PostExercise(Exercise exercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            exerciseRepository.InsertExercise(exercise);

            return Ok(exercise);
        }

   
    }
}