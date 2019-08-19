using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;

namespace LapbaseEntityFramework.Repositories
{
    public interface IExerciseRepository : IDisposable
    {
        IEnumerable<Exercise> GetExercises(long PatientID, long OrganizationCode);
        Exercise GetExerciseByID(long id);
        void InsertExercise(Exercise exercise);
        void DeleteExercise(long id);
        void UpdateExercise(Exercise exercise);
        void Save();
    }
}
