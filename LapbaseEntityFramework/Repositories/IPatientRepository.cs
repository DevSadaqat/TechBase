using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;

namespace LapbaseEntityFramework.Repositories
{
    public interface IPatientRepository : IDisposable
    {
        IEnumerable<Patient> GetPatients();
        Patient GetPatient(long id, long organizationCode);
        void UpdatePatient(Patient patient);
        void Save();
    }
}
