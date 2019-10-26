using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using System.Data.Entity;

namespace LapbaseEntityFramework.Repositories
{
    
    public class FoodItemRepository : IFoodItemRepository, IDisposable
    {
        private LapbaseContext Lb;

        public FoodItemRepository()
        {
            Lb = new LapbaseContext();
        }
        
        public FoodItem GetFoodItem(String name)
        {
            FoodItem foodItem = Lb.FoodItems.Find(name);
            return foodItem;
        }

       
        public IEnumerable<FoodItem> GetFoodItems()
        {
            var foods = Lb.FoodItems.Where(a=> a.FoodType!="Drink");
            return foods;
        }


        public IEnumerable<FoodItem> GetDrinks()
        {
            var foods = Lb.FoodItems.Where(a => a.FoodType == "Drink");
            return foods;
        }

        public void Save()
        {
            Lb.SaveChanges();
        }

        private bool disposed = false;

        //Used to clean up and free unmanaged resources

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Lb.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
