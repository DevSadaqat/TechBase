namespace EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Lapbase : DbContext
    {
        public Lapbase()
            : base("name=Lapbase")
        {
        }

        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<SystemDetail> SystemDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .Property(e => e.ExerciseType)
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

            modelBuilder.Entity<Food>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.FoodType)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

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

            var currentUsername = "Techie";
            foreach (var entity in entities)
            {
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
