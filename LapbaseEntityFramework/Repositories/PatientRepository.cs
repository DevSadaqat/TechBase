using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;

namespace LapbaseEntityFramework.Repositories
{
    public class PatientRepository : IPatientRepository, IDisposable
    {
        private LapbaseContext Lb;
        public PatientRepository()
        {
            Lb = new LapbaseContext();
        }


        public IEnumerable<Patient> GetPatients()
        {
            var patients = Lb.Patients.ToList();
            return patients;
        }
        public Patient GetPatient(long id, long organizationCode)
        {
            var patient = Lb.Patients.Find(id, organizationCode);
            return patient;
        }

        public void UpdatePatient(Patient patient)
        {
            Lb.Entry(patient).State = EntityState.Modified;
            Lb.Configuration.ValidateOnSaveEnabled = false;
            Save();
            Lb.Configuration.ValidateOnSaveEnabled = true;
        }


        public void Save()
        {
            Lb.SaveChanges();
        }
        private bool disposed = false;

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
