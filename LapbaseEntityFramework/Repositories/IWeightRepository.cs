using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using LapbaseEntityFramework.ViewModel;

namespace LapbaseEntityFramework.Repositories
{
    public interface IWeightRepository : IDisposable
    {
        IEnumerable<Weight> GetWeights(long PatientID, long OrganizationCode);
        Weight GetLatestWeight(long PatientID, long OrganizationCode);
        Weight GetWeightByID(long id);
        IEnumerable<WeightViewModel> GetAllWeights(long PatientID, long OrganizationCode);
        IEnumerable<BMIViewModel> GetAllBMIs(long PatientID, long OrganizationCode);
        void InsertWeight(Weight weight);
        void DeleteWeight(long id);
        void UpdateWeight(Weight weight);
        void Save();
    }
}
