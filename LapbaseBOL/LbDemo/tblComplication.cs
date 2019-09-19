namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblComplication
    {
        [Key]
        [Column(Order = 0)]
        public int ComplicationNum { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        public int PatientId { get; set; }

        public DateTime? ComplicationDate { get; set; }

        [StringLength(10)]
        public string ComplicationCode { get; set; }

        [StringLength(10)]
        public string TypeCode { get; set; }

        public bool Readmitted { get; set; }

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

        public bool ReOperation { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [StringLength(100)]
        public string Complication { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        [StringLength(100)]
        public string Facility_Other { get; set; }

        [StringLength(255)]
        public string AdverseSurgery { get; set; }

        public int DoctorID { get; set; }

        public DateTime? DateDeleted { get; set; }

        [StringLength(50)]
        public string DeletedByUser { get; set; }

        public DateTime? AdmitDate { get; set; }

        public DateTime? DischargeDate { get; set; }

        public DateTime? PerformDate { get; set; }

        [StringLength(50)]
        public string Reason { get; set; }
    }
}
