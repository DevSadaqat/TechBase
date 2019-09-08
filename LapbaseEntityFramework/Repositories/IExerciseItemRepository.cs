using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;

namespace LapbaseEntityFramework.Repositories
{
    public interface IExerciseItemRepository : IDisposable
    {
        IEnumerable<ExerciseItem> GetIntenseExercise();
        IEnumerable<ExerciseItem> GetLightExercise();
        IEnumerable<ExerciseItem> GetModerateExercise();
        void Save();
    }
}
