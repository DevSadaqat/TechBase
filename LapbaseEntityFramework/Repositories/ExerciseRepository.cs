using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapbaseBOL;
using System.Data.Entity;

namespace LapbaseEntityFramework.Repositories
{
    public class ExerciseRepository : IExerciseRepository, IDisposable
    {
        private LapbaseContext Lb;
        public ExerciseRepository()
        {
            Lb = new LapbaseContext();
        }

        public IEnumerable<Exercise> GetExercises(long PatientID, long OrganizationCode)
        {
            var exercises = Lb.Exercises.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode));
            return exercises;
        }

        public IEnumerable<Exercise> FilterLight(long PatientID, long OrganizationCode)
        {
            var exercises = Lb.Exercises.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.ExerciseItem.ExerciseType.Equals("Light"));
            return exercises;
        }

        public IEnumerable<Exercise> FilterModerate(long PatientID, long OrganizationCode)
        {
            var exercises = Lb.Exercises.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.ExerciseItem.ExerciseType.Equals("Moderate"));
            return exercises;
        }

        public IEnumerable<Exercise> FilterIntense(long PatientID, long OrganizationCode)
        {
            var exercises = Lb.Exercises.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.ExerciseItem.ExerciseType.Equals("Intense"));
            return exercises;
        }

        public IEnumerable<Exercise> FilterExerciseName(long PatientID, long OrganizationCode, string exerciseName)
        {
            var exercises = Lb.Exercises.Where(a => a.PatientID.Equals(PatientID) && a.OrganizationCode.Equals(OrganizationCode) && a.ExerciseName.Equals(exerciseName));
            return exercises;
        }

        public Exercise GetExerciseByID(long Id)
        {
            return Lb.Exercises.Find(Id);
        }

        public void InsertExercise(Exercise exercise)
        {
            Lb.Exercises.Add(exercise);
            Save();
        }

        public void DeleteExercise(long id)
        {
            Exercise exercise = Lb.Exercises.Find(id);
            Lb.Exercises.Remove(exercise);
        }

        public void UpdateExercise(Exercise exercise)
        {
            Lb.Entry(exercise).State = EntityState.Modified;
            Lb.Configuration.ValidateOnSaveEnabled = false;
            Save();
            Lb.Configuration.ValidateOnSaveEnabled = true;
        }

        public void Save()
        {
            Lb.SaveChanges();
        }

        private bool disposed = false;

        //Used to clean up and free unmanaged resources
        
        protected virtual void Dispose (bool disposing)
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
