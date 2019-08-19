using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using System.Data.Entity;

namespace LapbaseEntityFramework.Repositories
{
    public class WeightRepository : IWeightRepository, IDisposable
    {
        private LapbaseContext Lb;
        public WeightRepository()
        {
            Lb = new LapbaseContext();
        }

        public IEnumerable<Weight> GetWeights(long PatientID, long OrganizationCode)
        {
            var weight = Lb.Weights.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode));
            return weight;
        }

        public Weight GetWeightByID(long Id)
        {
            return Lb.Weights.Find(Id);
        }

        public void InsertWeight(Weight weight)
        {
            Lb.Weights.Add(weight);
            Save();
        }

        public void DeleteWeight(long id)
        {
            Weight weight = Lb.Weights.Find(id);
            Lb.Weights.Remove(weight);
        }

        public void UpdateWeight(Weight weight)
        {
            Lb.Entry(weight).State = EntityState.Modified;
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
