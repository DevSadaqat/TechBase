namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientBioChemistryLog")]
    public partial class tblPatientBioChemistryLog
    {
        [Key]
        public int BiochemistryNumLogID { get; set; }

        public int BiochemistryNum { get; set; }

        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        public int PatientId { get; set; }

        public DateTime? BiochemistryDate { get; set; }

        [StringLength(255)]
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

        public int? LogUserPracticeCode { get; set; }

        public DateTime? LogDateTime { get; set; }
    }
}
