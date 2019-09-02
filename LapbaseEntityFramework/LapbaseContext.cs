using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using LapbaseBOL;
namespace LapbaseEntityFramework
{    
    public partial class LapbaseContext : DbContext
    {
        public LapbaseContext()
            : base("name=Lapbase")
        {
        }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<ExerciseItem> ExerciseItems { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodItem> FoodItems { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<SystemDetail> SystemDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .Property(e => e.Duration)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Exercise>()
                .Property(e => e.StartTime)
                .IsFixedLength();

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
                .HasForeignKey(e => e.ItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.IntakeDate)
                .IsFixedLength();

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
                .Property(e => e.MealType)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.Calories)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .HasMany(e => e.Foods)
                .WithRequired(e => e.FoodItem)
                .HasForeignKey(e => e.ItemID)
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
                .HasMany(e => e.Patients)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.SystemDetails)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.ContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PatientState)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PinCode)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Insurance)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.InsuranceEmployer)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Exercises)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => new { e.PatientID, e.OrganizationCode })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Foods)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => new { e.PatientID, e.OrganizationCode })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => new { e.PatientID, e.OrganizationCode })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Weights)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => new { e.PatientID, e.OrganizationCode })
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
        }
        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseClass && (x.State == EntityState.Added || x.State == EntityState.Modified));
            //get username from session or authentication

            var currentUsername = "";
            foreach (var entity in entities)
            {
                if (entity.Entity is Food)
                {
                    long patientId = ((Food)entity.Entity).PatientID;
                    var patient = Patients.Where(a => a.ID.Equals(patientId)).FirstOrDefault();
                    currentUsername = patient.FirstName;
                }

                if (entity.Entity is Exercise)
                {
                    long patientId = ((Exercise)entity.Entity).PatientID;
                    var patient = Patients.Where(a => a.ID.Equals(patientId)).FirstOrDefault();
                    currentUsername = patient.FirstName;
                }

                if (entity.Entity is Weight)
                {
                    long patientId = ((Weight)entity.Entity).PatientID;
                    var patient = Patients.Where(a => a.ID.Equals(patientId)).FirstOrDefault();
                    currentUsername = patient.FirstName;
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
