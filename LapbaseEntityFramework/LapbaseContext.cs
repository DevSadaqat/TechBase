using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using LapbaseBOL;
using LapbaseBOL.LbDemo.SPClasses;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.RegularExpressions;
using LapbaseEntityFramework.LbDemo;

namespace LapbaseEntityFramework
{    
    public partial class LapbaseContext : DbContext
    {
        private static EnvironmentConfigBuilder enf = new EnvironmentConfigBuilder();
        static string connectionString = enf.getLBCS();


        public LapbaseContext()
            : base(connectionString)
        {
        }

        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<ExerciseItem> ExerciseItems { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodItem> FoodItems { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<SystemDetail> SystemDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .Property(e => e.ExerciseName)
                .IsUnicode(false);

            modelBuilder.Entity<Exercise>()
                .Property(e => e.Duration)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Exercise>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Exercise>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciseItem>()
                .Property(e => e.ExerciseName)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciseItem>()
                .Property(e => e.ExerciseType)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciseItem>()
                .Property(e => e.Calories)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciseItem>()
                .HasMany(e => e.Exercises)
                .WithRequired(e => e.ExerciseItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.FoodName)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.MealType)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.FoodName)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.Calories)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.FoodType)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .HasMany(e => e.Foods)
                .WithRequired(e => e.FoodItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.OrgDomainName)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.CulturalInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.SystemDetails)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Weight>()
                .Property(e => e.WeightValue)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Weight>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Weight>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Weight>()
                .Property(e => e.BMI)
                .HasPrecision(5, 2);
        }
        public override int SaveChanges()
        {
            LbDemoContext lb = new LbDemoContext();
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseClass && (x.State == EntityState.Added || x.State == EntityState.Modified));
            //get username from session or authentication

            var currentUsername = "";
            foreach (var entity in entities)
            {
                 if (entity.Entity is Food)
                 {
                     long patientId = ((Food)entity.Entity).PatientID;
                     var patient = lb.tblPatients.Where(a => a.Patient_Id==patientId).FirstOrDefault();
                     currentUsername = patient.Firstname;
                 }

                 if (entity.Entity is Exercise)
                 {
                     long patientId = ((Exercise)entity.Entity).PatientID;
                     var patient = lb.tblPatients.Where(a => a.Patient_Id==patientId).FirstOrDefault();
                     currentUsername = patient.Firstname;
                 }

                 if (entity.Entity is Weight)
                 {
                     long patientId = ((Weight)entity.Entity).PatientID;
                     var patient = lb.tblPatients.Where(a => a.Patient_Id==patientId).FirstOrDefault();
                     currentUsername = patient.Firstname;
                 }

                if (entity.State == EntityState.Added)
                {
                   

                    ((BaseClass)entity.Entity).CreatedAt = DateTime.Now;
                    ((BaseClass)entity.Entity).CreatedBy = currentUsername;
                }
                ((BaseClass)entity.Entity).ModifiedAt = DateTime.Now;
                ((BaseClass)entity.Entity).ModifiedBy = currentUsername;
                
            }
            return base.SaveChanges();
        }
        
}
}
