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

namespace LapbaseAPI.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class FoodController : ApiController
    {
        private readonly IFoodRepository foodRepository = new FoodRepository();

        // GET: api/Food
        public IHttpActionResult GetFoods(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.GetFoods(PatientID, OrganizationCode);
            return Ok(foods);
        }

        // GET: api/Food/5
        [ResponseType(typeof(Food))]
        public IHttpActionResult GetFood(long id)
        {
            var food = foodRepository.GetFoodByID(id);
            if (food == null)
            {
                return NotFound();
            }

            return Ok(food);
        }

        // PUT: api/Food/5
        [ResponseType(typeof(Food))]
        public IHttpActionResult PutFood(long id, Food food)
        {
            if (food.ID != id)
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
                    foodRepository.UpdateFood(food);
                    foodRepository.Save();
                    return Ok(food);
                }

            }

        }

        // POST: api/Food
        [ResponseType(typeof(Food))]
        public IHttpActionResult PostFood(Food food)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            foodRepository.InsertFood(food);


            return Ok(food);
        }
    }
      
}