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
        ExerciseItem GetExerciseItem(String name);
        IEnumerable<ExerciseItem> GetExercises();
        IEnumerable<ExerciseItem> GetIntenseExercises();
        IEnumerable<ExerciseItem> GetLightExercises();
        IEnumerable<ExerciseItem> GetModerateExercises();
        void Save();
    }
}
