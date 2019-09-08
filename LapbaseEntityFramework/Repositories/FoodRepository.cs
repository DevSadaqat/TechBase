using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using System.Data.Entity;
using LapbaseEntityFramework.ViewModel;

namespace LapbaseEntityFramework.Repositories
{
    public class FoodRepository : IFoodRepository, IDisposable
    {
        private LapbaseContext Lb;
        public FoodRepository()
        {
            Lb = new LapbaseContext();
        }

         //public IEnumerable<Food> GetFoods(long PatientID, long OrganizationCode)
        public IEnumerable<FoodViewModel> GetFoods(long PatientID, long OrganizationCode)
        {
            var foods = Lb.Foods.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode)).Select(x=> new FoodViewModel { FoodName=x.FoodItem.FoodName, MealType= x.FoodItem.MealType, Quantity = x.Quantity, Calories = x.FoodItem.Calories }).ToList();
            return foods;
        }

        public Food GetFoodByID(long Id)
        {
            return Lb.Foods.Find(Id);
        }

        public void InsertFood(Food food)
        {
            Lb.Foods.Add(food);
            Save();
        }

        public void DeleteFood(long id)
        {
            Food food = Lb.Foods.Find(id);
            Lb.Foods.Remove(food);
        }

        public void UpdateFood(Food food)
        {
            Lb.Entry(food).State = EntityState.Modified;
            Lb.Configuration.ValidateOnSaveEnabled = false;
            Save();
            Lb.Configuration.ValidateOnSaveEnabled = true;
        }

        public void Save()
        {
            Lb.SaveChanges();
        }

        private bool disposed = false;

        //Used to clean up and free unmanaged resources
        
        protected virtual void Dispose (bool disposing)
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
