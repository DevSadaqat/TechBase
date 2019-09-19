using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL.LbDemo.SPClasses;

namespace LapbaseEntityFramework.DemoRepositories
{
    
        public interface IPatientDemographicRepository : IDisposable
        {
        // IEnumerable<PatientDemographic> GetPatients();
            IEnumerable<PatientDemographic> GetPatient(long id, long organizationCode);
          
        }
    
}
