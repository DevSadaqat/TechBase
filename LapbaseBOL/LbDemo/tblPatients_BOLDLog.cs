namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblPatients_BOLDLog
    {
        [Key]
        public int PatientBoldLogID { get; set; }

        public int OrganizationCode { get; set; }

        [Column("Patient Id")]
        public int Patient_Id { get; set; }

        [StringLength(20)]
        public string Patient_CustomId { get; set; }

        [StringLength(50)]
        public string ChartNumber { get; set; }

        [StringLength(15)]
        public string SocialSecurityNumber { get; set; }

        [StringLength(6)]
        public string EmploymentStatus { get; set; }

        [StringLength(100)]
        public string EmployerName { get; set; }

        public bool HasInsurance { get; set; }

        public short IsCoverProcedure { get; set; }

        [StringLength(50)]
        public string SecondaryInsurance { get; set; }

        [StringLength(50)]
        public string TertiaryInsurance { get; set; }

        public bool IsSelfPay { get; set; }

        public bool IsCharity { get; set; }

        public decimal PreOperativeWeightLoss { get; set; }

        [StringLength(10)]
        public string DietryWeightLoss { get; set; }

        public bool DurationObesity { get; set; }

        public bool SmokingCessation { get; set; }

        public bool MentalHealthClearance { get; set; }

        public bool IQTesting { get; set; }

        [StringLength(100)]
        public string PreCertification_Other { get; set; }

        [StringLength(100)]
        public string PBS_Procedure { get; set; }

        public int PBS_Year { get; set; }

        public int PBS_SurgeonID { get; set; }

        public decimal OriginalWeight { get; set; }

        public bool OriginalWeight_Actual { get; set; }

        public decimal LowestWeightAchieved { get; set; }

        public bool LowestWeightAchieved_Actual { get; set; }

        [StringLength(100)]
        public string PBS_Event { get; set; }

        [StringLength(100)]
        public string PNBS_Procedure { get; set; }

        public bool? HasConsentedToSRC { get; set; }

        [StringLength(50)]
        public string BoldChartNumber { get; set; }

        [StringLength(50)]
        public string InsuranceNumber { get; set; }

        public bool IsMedicare { get; set; }

        public bool IsMedicaid { get; set; }

        public bool IsPrivateInsurance { get; set; }

        public bool IsGovernmentInsurance { get; set; }

        public int? LogUserPracticeCode { get; set; }

        public DateTime? LogDateTime { get; set; }
    }
}
