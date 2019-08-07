namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("lbd.Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Exercises = new HashSet<Exercise>();
            Foods = new HashSet<Food>();
            Users = new HashSet<User>();
            Weights = new HashSet<Weight>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrganizationCode { get; set; }

        [StringLength(10)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        public int? Height { get; set; }

        public long? PhoneNumber { get; set; }

        public long? Mobile { get; set; }

        [StringLength(30)]
        public string ContactEmail { get; set; }

        [StringLength(30)]
        public string Street { get; set; }

        [StringLength(20)]
        public string Suburb { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string PatientState { get; set; }

        [StringLength(5)]
        public string PinCode { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        [StringLength(40)]
        public string Insurance { get; set; }

        [StringLength(40)]
        public string InsuranceEmployer { get; set; }

        public long? InusuranceNumber { get; set; }

        public long? MedicareNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exercise> Exercises { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Food> Foods { get; set; }

        public virtual Organization Organization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Weight> Weights { get; set; }
    }
}
