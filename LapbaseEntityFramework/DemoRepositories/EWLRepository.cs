using LapbaseEntityFramework.LbDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using LapbaseBOL.LbDemo.SPClasses;
using System.Data.SqlClient;
using LapbaseEntityFramework.ViewModel;

namespace LapbaseEntityFramework.DemoRepositories
{
    public class EWLRepository : IEWLRepository, IDisposable
    {
        private LbDemoContext Lb;
        public EWLRepository()
        {
            Lb = new LbDemoContext();
        }

        public IEnumerable<EWLViewModel> GetEWLData(long id, long organizationCode)
        {
            var patientId = new SqlParameter("@PatientID", id);

            var orgCode = new SqlParameter("@OrganizationCode", organizationCode);

            int userCode = Lb.tblPatients.Where(a => a.Patient_Id == id && a.OrganizationCode == organizationCode).Select(a => a.UserPracticeCode).FirstOrDefault();

            var uCode = new SqlParameter("@UserPracticeCode", userCode);
            var imperialFlag = new SqlParameter("@ImperialFlag", 1);

            var collection = Lb.Database.SqlQuery<EWLModel>("Ver1_1_sp_Rep_EWL_WLGraphFullPage @OrganizationCode, @UserPracticeCode, @PatientID, @ImperialFlag", orgCode, uCode, patientId, imperialFlag).ToList();
            IEnumerable<EWLViewModel> ewlList = collection.Select(a => new EWLViewModel { Date = a.DateSeen_MY, EWL = a.EWL }).ToList();
            ewlList = ewlList.Take(10);
            return ewlList;
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
