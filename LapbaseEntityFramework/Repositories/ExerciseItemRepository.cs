using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using System.Data.Entity;

namespace LapbaseEntityFramework.Repositories
{
   public class ExerciseItemRepository : IExerciseItemRepository, IDisposable
    {
        private LapbaseContext Lb;

        public ExerciseItemRepository()
        {
            Lb = new LapbaseContext();
        }

        public IEnumerable<ExerciseItem> GetIntenseExercise()
        {
            var exercises = Lb.ExerciseItems.Where(a => a.ExerciseType.Equals("Intense"));
            return exercises;
        }

        public IEnumerable<ExerciseItem> GetLightExercise()
        {
            var exercises = Lb.ExerciseItems.Where(a => a.ExerciseType.Equals("Light"));
            return exercises;
        }

        public IEnumerable<ExerciseItem> GetModerateExercise()
        {
            var exercises = Lb.ExerciseItems.Where(a => a.ExerciseType.Equals("Moderate"));
            return exercises;
        }
        public void Save()
        {
            Lb.SaveChanges();
        }

        private bool disposed = false;

        //Used to clean up and free unmanaged resources

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
