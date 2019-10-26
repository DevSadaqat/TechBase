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
    public class FoodController : ApiController
    {
        private readonly IFoodRepository foodRepository = new FoodRepository();

        // GET: api/Food
        [HttpGet]
        public IHttpActionResult GetFoods(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.GetFoods(PatientID, OrganizationCode);
            return Ok(foods);
        }

        [HttpGet]
        public IHttpActionResult GetRecentFoods(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.GetRecentFoods(PatientID, OrganizationCode);
            return Ok(foods);
        }

        [HttpGet]
        public IHttpActionResult GetCaloriesConsumed(long PatientID, long OrganizationCode)
        {
            var calories = foodRepository.GetCaloriesConsumed(PatientID, OrganizationCode);
            return Ok(calories);
        }

        // GET: api/Food/5
        [HttpGet]
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

        [HttpGet]
        public IHttpActionResult FilterBreakfast(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.FilterBreakfast(PatientID, OrganizationCode);
            return Ok(foods);
        }

        [HttpGet]
        public IHttpActionResult FilterLunch(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.FilterLunch(PatientID, OrganizationCode);
            return Ok(foods);
        }

        [HttpGet]
        public IHttpActionResult FilterDinner(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.FilterDinner(PatientID, OrganizationCode);
            return Ok(foods);
        }

        [HttpGet]
        public IHttpActionResult FilterSmall(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.FilterSmall(PatientID, OrganizationCode);
            return Ok(foods);
        }

        [HttpGet]
        public IHttpActionResult FilterMedium(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.FilterMedium(PatientID, OrganizationCode);
            return Ok(foods);
        }

        [HttpGet]
        public IHttpActionResult FilterLarge(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.FilterLarge(PatientID, OrganizationCode);
            return Ok(foods);
        }

        [HttpGet]
        public IHttpActionResult FilterDrink(long PatientID, long OrganizationCode)
        {
            var foods = foodRepository.FilterDrink(PatientID, OrganizationCode);
            return Ok(foods);
        }

        [HttpGet]
        public IHttpActionResult FilterFoodName(long PatientID, long OrganizationCode, string foodName)
        {
            var foods = foodRepository.FilterFoodName(PatientID, OrganizationCode,foodName);
            return Ok(foods);
        }

    }
      
}