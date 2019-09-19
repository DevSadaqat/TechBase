﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using System.Data.Entity;


namespace LapbaseEntityFramework.Repositories
{
    public class FoodRepository : IFoodRepository, IDisposable
    {
        private LapbaseContext Lb;
        public FoodRepository()
        {
            Lb = new LapbaseContext();
        }

        public IEnumerable<Food> GetFoods(long PatientID, long OrganizationCode)
        {
            var foods = Lb.Foods.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode));
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

        public IEnumerable<Food> FilterBreakfast(long PatientID, long OrganizationCode)
        {
            var foods = Lb.Foods.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.MealType.Equals("Breakfast"));
            return foods;
        }


        public IEnumerable<Food> FilterLunch(long PatientID, long OrganizationCode)
        {
            var foods = Lb.Foods.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.MealType.Equals("Lunch"));
            return foods;
        }

        public IEnumerable<Food> FilterDinner(long PatientID, long OrganizationCode)
        {
            var foods = Lb.Foods.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.MealType.Equals("Dinner"));
            return foods;
        }

        public IEnumerable<Food> FilterSmall(long PatientID, long OrganizationCode)
        {
            var foods = Lb.Foods.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.Quantity.Equals("Small"));
            return foods;
        }

        public IEnumerable<Food> FilterMedium(long PatientID, long OrganizationCode)
        {
            var foods = Lb.Foods.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.Quantity.Equals("Medium"));
            return foods;
        }

        public IEnumerable<Food> FilterLarge(long PatientID, long OrganizationCode)
        {
            var foods = Lb.Foods.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.Quantity.Equals("Large"));
            return foods;
        }

        public IEnumerable<Food> FilterFoodName(long PatientID, long OrganizationCode, string foodName)
        {
            var foods = Lb.Foods.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.FoodName.Equals(foodName));
            return foods;
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
