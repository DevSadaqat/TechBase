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
    public class FoodItemController : ApiController
    {
        private readonly IFoodItemRepository foodItemRepository = new FoodItemRepository();

        [HttpGet]
        // GET: api/FoodItems
        public IHttpActionResult GetFoodItems()
        {
            var foods = foodItemRepository.GetFoodItems();
            return Ok(foods);
        }

        [HttpGet]
        // GET: api/FoodItems
        public IHttpActionResult GetDrinks()
        {
            var foods = foodItemRepository.GetDrinks();
            return Ok(foods);
        }

        [HttpGet]
        // GET: api/fooditem?name=rice
        [ResponseType(typeof(FoodItem))]
        public IHttpActionResult GetFood(string name)
        {
            var food = foodItemRepository.GetFoodItem(name);
            if (food == null)
            {
                return NotFound();
            }

            return Ok(food);
        }
    }
}
