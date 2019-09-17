using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using LapbaseEntityFramework.LbDemo;
using LapbaseBOL.LbDemo.SPClasses;
using System.Data.SqlClient;

namespace LapbaseEntityFramework.DemoRepositories
{
    public class PatientDemographicRepository : IPatientDemographicRepository, IDisposable
    {
        private LbDemoContext Lb;
        public PatientDemographicRepository()
        {
            Lb = new LbDemoContext();
        }

        public IEnumerable<PatientDemographic> GetPatient(long id, long organizationCode)
        {
            var patientId = new SqlParameter("@PatientId", id);

            var orgCode = new SqlParameter("@OrganizationCode", organizationCode);

            var collection = Lb.Database.SqlQuery<PatientDemographic>("sp_LoadPatientDataDemographic @OrganizationCode, @PatientId", orgCode, patientId).ToList();

            return collection;
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
