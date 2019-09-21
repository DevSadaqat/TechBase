using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using System.Data.Entity;
using LapbaseEntityFramework.ViewModel;
using LapbaseEntityFramework.LbDemo;

namespace LapbaseEntityFramework.Repositories
{
    public class WeightRepository : IWeightRepository, IDisposable
    {
        private LbDemoContext Lbd;
        private LapbaseContext Lb;
        public WeightRepository()
        {
            Lb = new LapbaseContext();
            Lbd = new LbDemoContext();
        }

        public IEnumerable<Weight> GetWeights(long PatientID, long OrganizationCode)
        {
            var weight = Lb.Weights.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode));
            return weight;
        }
        public Weight GetLatestWeight(long PatientID, long OrganizationCode)
        {
            var latestId = Lb.Weights.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode)).Max(p => p.ID);
            var weight = Lb.Weights.Find(latestId);
            return weight;
        }

        public IEnumerable<WeightViewModel> GetAllWeights(long PatientID, long OrganizationCode)
        {
            IEnumerable<WeightViewModel> weight1 = Lbd.tblPatientConsults.Where(a => a.Patient_Id==PatientID && a.OrganizationCode==OrganizationCode).Select(a => new WeightViewModel { weight = a.Weight, dateAdded = a.DateSeen }).ToList();

            IEnumerable<WeightViewModel> weight2 = Lb.Weights.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode)).Select(a => new WeightViewModel { weight = a.WeightValue, dateAdded= a.CreatedAt }).ToList();

            IEnumerable<WeightViewModel> allWeights = weight1.Concat(weight2);
            return allWeights;
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
