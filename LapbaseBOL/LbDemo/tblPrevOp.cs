namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPrevOp")]
    public partial class tblPrevOp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        public int PatientId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrevOpId { get; set; }

        public int Year { get; set; }

        public decimal OriginalWeight { get; set; }

        public bool OriginalWeight_Actual { get; set; }

        public decimal LowestWeightAchieved { get; set; }

        public bool LowestWeightAchieved_Actual { get; set; }

        [StringLength(100)]
        public string PrevOpSurgery { get; set; }

        [StringLength(255)]
        public string PrevOpEvent { get; set; }

        public int DoctorId { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(30)]
        public string CreatedByUser { get; set; }

        [StringLength(30)]
        public string CreatedByWindowsUser { get; set; }

        [StringLength(30)]
        public string CreatedByComputer { get; set; }

        public DateTime? LastModified { get; set; }

        [StringLength(30)]
        public string ModifiedByUser { get; set; }

        [StringLength(30)]
        public string ModifiedByWindowsUser { get; set; }

        [StringLength(30)]
        public string ModifiedByComputer { get; set; }

        public DateTime? DateDeleted { get; set; }

        [StringLength(50)]
        public string DeletedByUser { get; set; }
    }
}
