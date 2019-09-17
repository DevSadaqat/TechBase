namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientBioChemistry")]
    public partial class tblPatientBioChemistry
    {
        [Key]
        [Column(Order = 0)]
        public int BiochemistryNum { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        public int PatientId { get; set; }

        public DateTime? BiochemistryDate { get; set; }

        [StringLength(2000)]
        public string BiochemistryValue { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(30)]
        public string CreatedByUser { get; set; }

        public DateTime? LastModified { get; set; }

        [StringLength(30)]
        public string ModifiedByUser { get; set; }

        public DateTime? DateDeleted { get; set; }

        [StringLength(50)]
        public string DeletedByUser { get; set; }
    }
}
